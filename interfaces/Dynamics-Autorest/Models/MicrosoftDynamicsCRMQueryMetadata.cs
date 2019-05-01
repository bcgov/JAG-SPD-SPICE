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
    /// QueryMetadata
    /// </summary>
    public partial class MicrosoftDynamicsCRMQueryMetadata
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMQueryMetadata
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMQueryMetadata()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMQueryMetadata
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMQueryMetadata(string queryId = default(string), string returnedTypeCode = default(string), int? componentState = default(int?), string name = default(string), string description = default(string), string fetchXml = default(string), string layoutXml = default(string), bool? isDefault = default(bool?), string modifiedOn = default(string), string queryApi = default(string), int? queryType = default(int?), bool? isCustomizable = default(bool?))
        {
            QueryId = queryId;
            ReturnedTypeCode = returnedTypeCode;
            ComponentState = componentState;
            Name = name;
            Description = description;
            FetchXml = fetchXml;
            LayoutXml = layoutXml;
            IsDefault = isDefault;
            ModifiedOn = modifiedOn;
            QueryApi = queryApi;
            QueryType = queryType;
            IsCustomizable = isCustomizable;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "QueryId")]
        public string QueryId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ReturnedTypeCode")]
        public string ReturnedTypeCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ComponentState")]
        public int? ComponentState { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FetchXml")]
        public string FetchXml { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LayoutXml")]
        public string LayoutXml { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsDefault")]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ModifiedOn")]
        public string ModifiedOn { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "QueryApi")]
        public string QueryApi { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "QueryType")]
        public int? QueryType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsCustomizable")]
        public bool? IsCustomizable { get; set; }

    }
}
