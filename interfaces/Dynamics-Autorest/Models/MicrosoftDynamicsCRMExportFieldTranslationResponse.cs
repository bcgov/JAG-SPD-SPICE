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
    /// ExportFieldTranslationResponse
    /// </summary>
    public partial class MicrosoftDynamicsCRMExportFieldTranslationResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMExportFieldTranslationResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMExportFieldTranslationResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMExportFieldTranslationResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMExportFieldTranslationResponse(object exportTranslationFile = default(object))
        {
            ExportTranslationFile = exportTranslationFile;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ExportTranslationFile")]
        public object ExportTranslationFile { get; set; }

    }
}