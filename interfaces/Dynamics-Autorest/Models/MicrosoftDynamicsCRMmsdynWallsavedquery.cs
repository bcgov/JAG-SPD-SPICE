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
    /// msdyn_wallsavedquery
    /// </summary>
    public partial class MicrosoftDynamicsCRMmsdynWallsavedquery
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmsdynWallsavedquery class.
        /// </summary>
        public MicrosoftDynamicsCRMmsdynWallsavedquery()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmsdynWallsavedquery class.
        /// </summary>
        public MicrosoftDynamicsCRMmsdynWallsavedquery(string msdynWallsavedqueryid = default(string), string _modifiedonbehalfbyValue = default(string), bool? msdynIsvisible = default(bool?), string msdynSavedqueryname = default(string), long? versionnumber = default(long?), int? msdynOtc = default(int?), int? statecode = default(int?), int? utcconversiontimezonecode = default(int?), string _organizationidValue = default(string), bool? msdynIsvirtual = default(bool?), int? msdynIsvisiblebit = default(int?), int? timezoneruleversionnumber = default(int?), int? statuscode = default(int?), string _modifiedbyValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string msdynEntitydisplayname = default(string), string _createdonbehalfbyValue = default(string), int? importsequencenumber = default(int?), string msdynSavedqueryid = default(string), string _msdynPostconfigurationidValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _createdbyValue = default(string), string msdynEntityname = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), IList<MicrosoftDynamicsCRMsyncerror> msdynWallsavedquerySyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMasyncoperation> msdynWallsavedqueryAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> msdynWallsavedqueryMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> msdynWallsavedqueryProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> msdynWallsavedqueryBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> msdynWallsavedqueryPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMmsdynPostconfig msdynPostconfigurationid = default(MicrosoftDynamicsCRMmsdynPostconfig), IList<MicrosoftDynamicsCRMmsdynWallsavedqueryusersettings> msdynWallsavedqueryWallsavedqueryusersettings = default(IList<MicrosoftDynamicsCRMmsdynWallsavedqueryusersettings>))
        {
            MsdynWallsavedqueryid = msdynWallsavedqueryid;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            MsdynIsvisible = msdynIsvisible;
            MsdynSavedqueryname = msdynSavedqueryname;
            Versionnumber = versionnumber;
            MsdynOtc = msdynOtc;
            Statecode = statecode;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._organizationidValue = _organizationidValue;
            MsdynIsvirtual = msdynIsvirtual;
            MsdynIsvisiblebit = msdynIsvisiblebit;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Statuscode = statuscode;
            this._modifiedbyValue = _modifiedbyValue;
            Overriddencreatedon = overriddencreatedon;
            MsdynEntitydisplayname = msdynEntitydisplayname;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Importsequencenumber = importsequencenumber;
            MsdynSavedqueryid = msdynSavedqueryid;
            this._msdynPostconfigurationidValue = _msdynPostconfigurationidValue;
            Modifiedon = modifiedon;
            Createdon = createdon;
            this._createdbyValue = _createdbyValue;
            MsdynEntityname = msdynEntityname;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Organizationid = organizationid;
            MsdynWallsavedquerySyncErrors = msdynWallsavedquerySyncErrors;
            MsdynWallsavedqueryAsyncOperations = msdynWallsavedqueryAsyncOperations;
            MsdynWallsavedqueryMailboxTrackingFolders = msdynWallsavedqueryMailboxTrackingFolders;
            MsdynWallsavedqueryProcessSession = msdynWallsavedqueryProcessSession;
            MsdynWallsavedqueryBulkDeleteFailures = msdynWallsavedqueryBulkDeleteFailures;
            MsdynWallsavedqueryPrincipalObjectAttributeAccesses = msdynWallsavedqueryPrincipalObjectAttributeAccesses;
            MsdynPostconfigurationid = msdynPostconfigurationid;
            MsdynWallsavedqueryWallsavedqueryusersettings = msdynWallsavedqueryWallsavedqueryusersettings;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_wallsavedqueryid")]
        public string MsdynWallsavedqueryid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_isvisible")]
        public bool? MsdynIsvisible { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_savedqueryname")]
        public string MsdynSavedqueryname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_otc")]
        public int? MsdynOtc { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_isvirtual")]
        public bool? MsdynIsvirtual { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_isvisiblebit")]
        public int? MsdynIsvisiblebit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_entitydisplayname")]
        public string MsdynEntitydisplayname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_savedqueryid")]
        public string MsdynSavedqueryid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_msdyn_postconfigurationid_value")]
        public string _msdynPostconfigurationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_entityname")]
        public string MsdynEntityname { get; set; }

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
        [JsonProperty(PropertyName = "msdyn_wallsavedquery_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> MsdynWallsavedquerySyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_wallsavedquery_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> MsdynWallsavedqueryAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_wallsavedquery_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> MsdynWallsavedqueryMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_wallsavedquery_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> MsdynWallsavedqueryProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_wallsavedquery_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> MsdynWallsavedqueryBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_wallsavedquery_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> MsdynWallsavedqueryPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_postconfigurationid")]
        public MicrosoftDynamicsCRMmsdynPostconfig MsdynPostconfigurationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_wallsavedquery_wallsavedqueryusersettings")]
        public IList<MicrosoftDynamicsCRMmsdynWallsavedqueryusersettings> MsdynWallsavedqueryWallsavedqueryusersettings { get; set; }

    }
}