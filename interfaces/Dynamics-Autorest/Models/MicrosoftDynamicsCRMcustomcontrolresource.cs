// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.Spice.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// customcontrolresource
    /// </summary>
    public partial class MicrosoftDynamicsCRMcustomcontrolresource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMcustomcontrolresource class.
        /// </summary>
        public MicrosoftDynamicsCRMcustomcontrolresource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMcustomcontrolresource class.
        /// </summary>
        public MicrosoftDynamicsCRMcustomcontrolresource(string _organizationidValue = default(string), string version = default(string), string webresourceid = default(string), int? componentstate = default(int?), long? versionnumber = default(long?), string customcontrolresourceid = default(string), string versionrequirement = default(string), string _modifiedonbehalfbyValue = default(string), string solutionid = default(string), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _createdbyValue = default(string), string introducedversion = default(string), string customcontrolresourceidunique = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string name = default(string), bool? ismanaged = default(bool?), string _createdonbehalfbyValue = default(string), string _modifiedbyValue = default(string), string customcontrolid = default(string), MicrosoftDynamicsCRMcustomcontrol customcontrolidCustomcontrol = default(MicrosoftDynamicsCRMcustomcontrol), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization))
        {
            this._organizationidValue = _organizationidValue;
            Version = version;
            Webresourceid = webresourceid;
            Componentstate = componentstate;
            Versionnumber = versionnumber;
            Customcontrolresourceid = customcontrolresourceid;
            Versionrequirement = versionrequirement;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Solutionid = solutionid;
            Overwritetime = overwritetime;
            Modifiedon = modifiedon;
            this._createdbyValue = _createdbyValue;
            Introducedversion = introducedversion;
            Customcontrolresourceidunique = customcontrolresourceidunique;
            Createdon = createdon;
            Name = name;
            Ismanaged = ismanaged;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._modifiedbyValue = _modifiedbyValue;
            Customcontrolid = customcontrolid;
            CustomcontrolidCustomcontrol = customcontrolidCustomcontrol;
            Createdby = createdby;
            Modifiedby = modifiedby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Organizationid = organizationid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "webresourceid")]
        public string Webresourceid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "componentstate")]
        public int? Componentstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "customcontrolresourceid")]
        public string Customcontrolresourceid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionrequirement")]
        public string Versionrequirement { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public string Solutionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "introducedversion")]
        public string Introducedversion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "customcontrolresourceidunique")]
        public string Customcontrolresourceidunique { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "customcontrolid")]
        public string Customcontrolid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "customcontrolid_customcontrol")]
        public MicrosoftDynamicsCRMcustomcontrol CustomcontrolidCustomcontrol { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

    }
}
