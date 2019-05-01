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
    /// constraintbasedgroup
    /// </summary>
    public partial class MicrosoftDynamicsCRMconstraintbasedgroup
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMconstraintbasedgroup class.
        /// </summary>
        public MicrosoftDynamicsCRMconstraintbasedgroup()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMconstraintbasedgroup class.
        /// </summary>
        public MicrosoftDynamicsCRMconstraintbasedgroup(int? grouptypecode = default(int?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _organizationidValue = default(string), string description = default(string), int? timezoneruleversionnumber = default(int?), int? utcconversiontimezonecode = default(int?), long? versionnumber = default(long?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _modifiedbyValue = default(string), int? importsequencenumber = default(int?), string _createdbyValue = default(string), string _modifiedonbehalfbyValue = default(string), string constraintbasedgroupid = default(string), string _createdonbehalfbyValue = default(string), string _businessunitidValue = default(string), string name = default(string), string constraints = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMbusinessunit businessunitidBusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> constraintbasedgroupSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMasyncoperation> constraintBasedGroupAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> constraintbasedgroupMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> constraintBasedGroupProcessSessions = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> constraintBasedGroupBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> constraintbasedgroupPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), IList<MicrosoftDynamicsCRMconnection> constraintbasedgroupConnections1 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMconnection> constraintbasedgroupConnections2 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMresourcegroup> constraintbasedgroupResourceGroups = default(IList<MicrosoftDynamicsCRMresourcegroup>), IList<MicrosoftDynamicsCRMresourcespec> constraintBasedGroupResourceSpecs = default(IList<MicrosoftDynamicsCRMresourcespec>), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), MicrosoftDynamicsCRMsystemuser businessunitidSystemuser = default(MicrosoftDynamicsCRMsystemuser))
        {
            Grouptypecode = grouptypecode;
            Createdon = createdon;
            this._organizationidValue = _organizationidValue;
            Description = description;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Versionnumber = versionnumber;
            Modifiedon = modifiedon;
            this._modifiedbyValue = _modifiedbyValue;
            Importsequencenumber = importsequencenumber;
            this._createdbyValue = _createdbyValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Constraintbasedgroupid = constraintbasedgroupid;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._businessunitidValue = _businessunitidValue;
            Name = name;
            Constraints = constraints;
            Overriddencreatedon = overriddencreatedon;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            BusinessunitidBusinessunit = businessunitidBusinessunit;
            ConstraintbasedgroupSyncErrors = constraintbasedgroupSyncErrors;
            ConstraintBasedGroupAsyncOperations = constraintBasedGroupAsyncOperations;
            ConstraintbasedgroupMailboxTrackingFolders = constraintbasedgroupMailboxTrackingFolders;
            ConstraintBasedGroupProcessSessions = constraintBasedGroupProcessSessions;
            ConstraintBasedGroupBulkDeleteFailures = constraintBasedGroupBulkDeleteFailures;
            ConstraintbasedgroupPrincipalObjectAttributeAccesses = constraintbasedgroupPrincipalObjectAttributeAccesses;
            ConstraintbasedgroupConnections1 = constraintbasedgroupConnections1;
            ConstraintbasedgroupConnections2 = constraintbasedgroupConnections2;
            ConstraintbasedgroupResourceGroups = constraintbasedgroupResourceGroups;
            ConstraintBasedGroupResourceSpecs = constraintBasedGroupResourceSpecs;
            Organizationid = organizationid;
            BusinessunitidSystemuser = businessunitidSystemuser;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "grouptypecode")]
        public int? Grouptypecode { get; set; }

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
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "constraintbasedgroupid")]
        public string Constraintbasedgroupid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_businessunitid_value")]
        public string _businessunitidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "constraints")]
        public string Constraints { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

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
        [JsonProperty(PropertyName = "businessunitid_businessunit")]
        public MicrosoftDynamicsCRMbusinessunit BusinessunitidBusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "constraintbasedgroup_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> ConstraintbasedgroupSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ConstraintBasedGroup_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> ConstraintBasedGroupAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "constraintbasedgroup_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> ConstraintbasedgroupMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ConstraintBasedGroup_ProcessSessions")]
        public IList<MicrosoftDynamicsCRMprocesssession> ConstraintBasedGroupProcessSessions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ConstraintBasedGroup_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> ConstraintBasedGroupBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "constraintbasedgroup_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> ConstraintbasedgroupPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "constraintbasedgroup_connections1")]
        public IList<MicrosoftDynamicsCRMconnection> ConstraintbasedgroupConnections1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "constraintbasedgroup_connections2")]
        public IList<MicrosoftDynamicsCRMconnection> ConstraintbasedgroupConnections2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "constraintbasedgroup_resource_groups")]
        public IList<MicrosoftDynamicsCRMresourcegroup> ConstraintbasedgroupResourceGroups { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "constraint_based_group_resource_specs")]
        public IList<MicrosoftDynamicsCRMresourcespec> ConstraintBasedGroupResourceSpecs { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "businessunitid_systemuser")]
        public MicrosoftDynamicsCRMsystemuser BusinessunitidSystemuser { get; set; }

    }
}
