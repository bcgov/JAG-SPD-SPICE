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
    /// ExportTranslationResponse
    /// </summary>
    public partial class MicrosoftDynamicsCRMExportTranslationResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMExportTranslationResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMExportTranslationResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMExportTranslationResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMExportTranslationResponse(object exportTranslationFile = default(object))
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
