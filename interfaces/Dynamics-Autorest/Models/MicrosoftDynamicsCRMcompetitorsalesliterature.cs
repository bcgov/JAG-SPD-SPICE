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
    /// competitorsalesliterature
    /// </summary>
    public partial class MicrosoftDynamicsCRMcompetitorsalesliterature
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMcompetitorsalesliterature class.
        /// </summary>
        public MicrosoftDynamicsCRMcompetitorsalesliterature()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMcompetitorsalesliterature class.
        /// </summary>
        public MicrosoftDynamicsCRMcompetitorsalesliterature(int? timezoneruleversionnumber = default(int?), string name = default(string), string salesliteratureid = default(string), string competitorid = default(string), string competitorsalesliteratureid = default(string), long? versionnumber = default(long?), int? importsequencenumber = default(int?), int? utcconversiontimezonecode = default(int?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), IList<MicrosoftDynamicsCRMasyncoperation> competitorsalesliteratureAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> competitorsalesliteratureMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMbulkdeletefailure> competitorsalesliteratureBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> competitorsalesliteraturePrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>))
        {
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Name = name;
            Salesliteratureid = salesliteratureid;
            Competitorid = competitorid;
            Competitorsalesliteratureid = competitorsalesliteratureid;
            Versionnumber = versionnumber;
            Importsequencenumber = importsequencenumber;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Overriddencreatedon = overriddencreatedon;
            CompetitorsalesliteratureAsyncOperations = competitorsalesliteratureAsyncOperations;
            CompetitorsalesliteratureMailboxTrackingFolders = competitorsalesliteratureMailboxTrackingFolders;
            CompetitorsalesliteratureBulkDeleteFailures = competitorsalesliteratureBulkDeleteFailures;
            CompetitorsalesliteraturePrincipalObjectAttributeAccesses = competitorsalesliteraturePrincipalObjectAttributeAccesses;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "salesliteratureid")]
        public string Salesliteratureid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "competitorid")]
        public string Competitorid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "competitorsalesliteratureid")]
        public string Competitorsalesliteratureid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "competitorsalesliterature_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> CompetitorsalesliteratureAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "competitorsalesliterature_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> CompetitorsalesliteratureMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "competitorsalesliterature_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> CompetitorsalesliteratureBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "competitorsalesliterature_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> CompetitorsalesliteraturePrincipalObjectAttributeAccesses { get; set; }

    }
}