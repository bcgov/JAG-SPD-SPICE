// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.Spice.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// spice_services
    /// </summary>
    public partial class MicrosoftDynamicsCRMspiceServices
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMspiceServices
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMspiceServices()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMspiceServices
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMspiceServices(string _spiceMinistryserviceidValue = default(string), object spiceIntermediate = default(object), int? utcconversiontimezonecode = default(int?), object spiceNoadjudication = default(object), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _organizationidValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _modifiedonbehalfbyValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), object exchangerate = default(object), string spiceName = default(string), object spiceSimple = default(object), object spiceIntermediateBase = default(object), string _modifiedbyValue = default(string), string spiceServicesid = default(string), string _createdbyValue = default(string), int? statecode = default(int?), int? importsequencenumber = default(int?), object spiceDifficultBase = default(object), int? statuscode = default(int?), object spiceDifficult = default(object), long? versionnumber = default(long?), string _createdonbehalfbyValue = default(string), object spiceSimpleBase = default(object), string _transactioncurrencyidValue = default(string), int? timezoneruleversionnumber = default(int?), object spiceNoadjudicationBase = default(object), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), IList<MicrosoftDynamicsCRMsyncerror> spiceServicesSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> spiceServicesDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> spiceServicesDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> spiceServicesAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> spiceServicesMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> spiceServicesProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> spiceServicesBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> spiceServicesPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMspiceMinistry spiceMinistryServiceId = default(MicrosoftDynamicsCRMspiceMinistry), IList<MicrosoftDynamicsCRMincident> spiceSpiceServicesIncident = default(IList<MicrosoftDynamicsCRMincident>))
        {
            this._spiceMinistryserviceidValue = _spiceMinistryserviceidValue;
            SpiceIntermediate = spiceIntermediate;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            SpiceNoadjudication = spiceNoadjudication;
            Createdon = createdon;
            this._organizationidValue = _organizationidValue;
            Modifiedon = modifiedon;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Overriddencreatedon = overriddencreatedon;
            Exchangerate = exchangerate;
            SpiceName = spiceName;
            SpiceSimple = spiceSimple;
            SpiceIntermediateBase = spiceIntermediateBase;
            this._modifiedbyValue = _modifiedbyValue;
            SpiceServicesid = spiceServicesid;
            this._createdbyValue = _createdbyValue;
            Statecode = statecode;
            Importsequencenumber = importsequencenumber;
            SpiceDifficultBase = spiceDifficultBase;
            Statuscode = statuscode;
            SpiceDifficult = spiceDifficult;
            Versionnumber = versionnumber;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            SpiceSimpleBase = spiceSimpleBase;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            SpiceNoadjudicationBase = spiceNoadjudicationBase;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Organizationid = organizationid;
            SpiceServicesSyncErrors = spiceServicesSyncErrors;
            SpiceServicesDuplicateMatchingRecord = spiceServicesDuplicateMatchingRecord;
            SpiceServicesDuplicateBaseRecord = spiceServicesDuplicateBaseRecord;
            SpiceServicesAsyncOperations = spiceServicesAsyncOperations;
            SpiceServicesMailboxTrackingFolders = spiceServicesMailboxTrackingFolders;
            SpiceServicesProcessSession = spiceServicesProcessSession;
            SpiceServicesBulkDeleteFailures = spiceServicesBulkDeleteFailures;
            SpiceServicesPrincipalObjectAttributeAccesses = spiceServicesPrincipalObjectAttributeAccesses;
            Transactioncurrencyid = transactioncurrencyid;
            SpiceMinistryServiceId = spiceMinistryServiceId;
            SpiceSpiceServicesIncident = spiceSpiceServicesIncident;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_spice_ministryserviceid_value")]
        public string _spiceMinistryserviceidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_intermediate")]
        public object SpiceIntermediate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_noadjudication")]
        public object SpiceNoadjudication { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public object Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_name")]
        public string SpiceName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_simple")]
        public object SpiceSimple { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_intermediate_base")]
        public object SpiceIntermediateBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_servicesid")]
        public string SpiceServicesid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_difficult_base")]
        public object SpiceDifficultBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_difficult")]
        public object SpiceDifficult { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_simple_base")]
        public object SpiceSimpleBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_noadjudication_base")]
        public object SpiceNoadjudicationBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_services_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> SpiceServicesSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_services_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> SpiceServicesDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_services_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> SpiceServicesDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_services_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> SpiceServicesAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_services_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> SpiceServicesMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_services_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> SpiceServicesProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_services_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> SpiceServicesBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_services_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> SpiceServicesPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_MinistryServiceId")]
        public MicrosoftDynamicsCRMspiceMinistry SpiceMinistryServiceId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_spice_services_incident")]
        public IList<MicrosoftDynamicsCRMincident> SpiceSpiceServicesIncident { get; set; }

    }
}
