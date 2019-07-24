﻿using Gov.Jag.Spice.Interfaces;
using Gov.Jag.Spice.Interfaces.Models;
using Gov.Jag.Spice.Public.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gov.Jag.Spice.Public.Utils
{
    public static class DynamicsUtility
    {
        public static async Task<IEnumerable<MicrosoftDynamicsCRMspiceGovministry>> GetMinistriesAsync(IDynamicsClient dynamicsClient)
        {
            var entities = (await dynamicsClient.Govministries.GetAsync()).Value;
            if (!entities.Any())
            {
                throw new DynamicsEntityNotFoundException(nameof(MicrosoftDynamicsCRMspiceGovministry));
            }

            return entities;
        }

        public static async Task<IEnumerable<MicrosoftDynamicsCRMspiceMinistry>> GetProgramAreasAsync(IDynamicsClient dynamicsClient)
        {
            var entities = (await dynamicsClient.Ministries.GetAsync()).Value;
            if (!entities.Any())
            {
                throw new DynamicsEntityNotFoundException(nameof(MicrosoftDynamicsCRMspiceMinistry));
            }

            return entities;
        }

        public static async Task<IEnumerable<MicrosoftDynamicsCRMspiceServices>> GetScreeningTypesAsync(IDynamicsClient dynamicsClient)
        {
            var entities = (await dynamicsClient.Serviceses.GetAsync()).Value;
            if (!entities.Any())
            {
                throw new DynamicsEntityNotFoundException(nameof(MicrosoftDynamicsCRMspiceServices));
            }

            return entities;
        }

        public static async Task<IEnumerable<MicrosoftDynamicsCRMspiceReasonforscreening>> GetScreeningReasonsAsync(IDynamicsClient dynamicsClient)
        {
            var entities = (await dynamicsClient.Reasonforscreenings.GetAsync()).Value;
            if (!entities.Any())
            {
                throw new DynamicsEntityNotFoundException(nameof(MicrosoftDynamicsCRMspiceReasonforscreening));
            }

            return entities;
        }

        public static async Task<MicrosoftDynamicsCRMspiceReasonforscreening> GetScreeningReasonAsync(IDynamicsClient dynamicsClient, string reasonId)
        {
            string filter = $"spice_reasonforscreeningid eq {reasonId}";
            var entities = (await dynamicsClient.Reasonforscreenings.GetAsync(filter: filter)).Value;
            if (!entities.Any())
            {
                throw new DynamicsEntityNotFoundException(nameof(MicrosoftDynamicsCRMspiceReasonforscreening), filter);
            }

            return entities.FirstOrDefault();
        }

        public static async Task<MicrosoftDynamicsCRMcontact> GetCandidateAsync(IDynamicsClient dynamicsClient, Candidate candidate)
        {
            string filter = $"fullname eq '{candidate.FirstName} {candidate.LastName}' and middlename eq '{candidate.MiddleName}' and spice_dateofbirth eq {candidate.DateOfBirth.ToString("o")} and emailaddress1 eq '{candidate.Email}' and spice_positiontitle eq '{candidate.Position}'";
            var entities = (await dynamicsClient.Contacts.GetAsync(filter: filter)).Value;
            return entities.FirstOrDefault();
        }

        public static async Task<MicrosoftDynamicsCRMcontact> GetSubmitterAsync(IDynamicsClient dynamicsClient, User user)
        {
            string filter = $"spice_portalcontactidentifier eq '{user.Id}'";
            var entities = (await dynamicsClient.Contacts.GetAsync(filter: filter)).Value;
            return entities.FirstOrDefault();
        }

        public static async Task<MicrosoftDynamicsCRMspiceMinistryemployee> GetContactAsync(IDynamicsClient dynamicsClient, Contact contact)
        {
            string filter = $"spice_name eq '{contact.FirstName}' and spice_lastname eq '{contact.LastName}' and spice_email eq '{contact.Email}'";
            var entity = (await dynamicsClient.Ministryemployees.GetAsync(filter: filter)).Value;
            return entity.FirstOrDefault();
        }

        public static async Task<MicrosoftDynamicsCRMcontact> CreateCandidateAsync(IDynamicsClient dynamicsClient, Candidate candidate)
        {
            var entity = new MicrosoftDynamicsCRMcontact
            {
                Fullname = $"{candidate.FirstName} {candidate.LastName}",
                Firstname = candidate.FirstName,
                Middlename = candidate.MiddleName,
                Lastname = candidate.LastName,
                SpiceDateofbirth = candidate.DateOfBirth,
                Emailaddress1 = candidate.Email,
                SpicePositiontitle = candidate.Position,
            };

            entity = await dynamicsClient.Contacts.CreateAsync(entity);
            return entity;
        }

        public static async Task<MicrosoftDynamicsCRMcontact> CreateSubmitterAsync(IDynamicsClient dynamicsClient, User user)
        {
            var entity = new MicrosoftDynamicsCRMcontact
            {
                Fullname = $"{user.GivenName} {user.Surname}",
                Firstname = user.GivenName,
                Lastname = user.Surname,
                Emailaddress1 = user.Email,
                SpicePortalcontactidentifier = user.Id

            };

            entity = await dynamicsClient.Contacts.CreateAsync(entity);
            return entity;
        }

        public static async Task<MicrosoftDynamicsCRMspiceMinistryemployee> CreateContactAsync(IDynamicsClient dynamicsClient, Contact contact, string programAreaId)
        {
            string programArea = dynamicsClient.GetEntityURI("spice_ministries", programAreaId);

            var entity = new MicrosoftDynamicsCRMspiceMinistryemployee
            {
                SpiceName = contact.FirstName,
                SpiceLastname = contact.LastName,
                SpiceEmail = contact.Email,
                SpiceMinistryIdODataBind = programArea,
            };

            entity = await dynamicsClient.Ministryemployees.CreateAsync(entity);
            return entity;
        }

        public static async Task<MicrosoftDynamicsCRMincident> CreateScreeningRequestAsync(IDynamicsClient dynamicsClient, ScreeningRequest screeningRequest, string candidateId, string submitterId, string contactId, int? applicantType, int? cannabisApplicantType)
        {
            string candidate = dynamicsClient.GetEntityURI("contacts", candidateId);
            string submitter = dynamicsClient.GetEntityURI("contacts", submitterId);
            string programArea = dynamicsClient.GetEntityURI("spice_ministries", screeningRequest.ProgramArea);
            string screeningType = dynamicsClient.GetEntityURI("spice_serviceses", screeningRequest.ScreeningType);
            string reason = dynamicsClient.GetEntityURI("spice_reasonforscreenings", screeningRequest.Reason);
            string contact = dynamicsClient.GetEntityURI("spice_ministryemployees", contactId);

            var entity = new MicrosoftDynamicsCRMincident
            {
                CustomerIdODataBind = candidate,
                ApplyingPersonIdODataBind = submitter,
                SpiceClientIdODataBind = programArea,
                SpiceServiceIdODataBind = screeningType,
                SpiceReasonForScreeningIdODataBind = reason,
                SpiceOtherscreeningreason = screeningRequest.OtherReason,
                SpiceReturnToIdODataBind = contact,
                SpiceApplicanttype = applicantType,
                SpiceCannabisapplicanttype = cannabisApplicantType,
            };

            entity = await dynamicsClient.Incidents.CreateAsync(entity);
            return entity;
        }
    }
}
