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
    /// contactquotes
    /// </summary>
    public partial class MicrosoftDynamicsCRMcontactquotes
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMcontactquotes
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMcontactquotes()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMcontactquotes
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMcontactquotes(int? importsequencenumber = default(int?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string quoteid = default(string), long? versionnumber = default(long?), int? timezoneruleversionnumber = default(int?), string contactquoteid = default(string), int? utcconversiontimezonecode = default(int?), string name = default(string), string contactid = default(string), IList<MicrosoftDynamicsCRMasyncoperation> contactquotesAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> contactquotesMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMbulkdeletefailure> contactquotesBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> contactquotesPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>))
        {
            Importsequencenumber = importsequencenumber;
            Overriddencreatedon = overriddencreatedon;
            Quoteid = quoteid;
            Versionnumber = versionnumber;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Contactquoteid = contactquoteid;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Name = name;
            Contactid = contactid;
            ContactquotesAsyncOperations = contactquotesAsyncOperations;
            ContactquotesMailboxTrackingFolders = contactquotesMailboxTrackingFolders;
            ContactquotesBulkDeleteFailures = contactquotesBulkDeleteFailures;
            ContactquotesPrincipalObjectAttributeAccesses = contactquotesPrincipalObjectAttributeAccesses;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quoteid")]
        public string Quoteid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contactquoteid")]
        public string Contactquoteid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contactid")]
        public string Contactid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contactquotes_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> ContactquotesAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contactquotes_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> ContactquotesMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contactquotes_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> ContactquotesBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contactquotes_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> ContactquotesPrincipalObjectAttributeAccesses { get; set; }

    }
}
