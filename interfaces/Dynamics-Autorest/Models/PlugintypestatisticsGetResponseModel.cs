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
    /// Collection of plugintypestatistics
    /// </summary>
    public partial class PlugintypestatisticsGetResponseModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// PlugintypestatisticsGetResponseModel class.
        /// </summary>
        public PlugintypestatisticsGetResponseModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// PlugintypestatisticsGetResponseModel class.
        /// </summary>
        public PlugintypestatisticsGetResponseModel(IList<MicrosoftDynamicsCRMplugintypestatistic> value = default(IList<MicrosoftDynamicsCRMplugintypestatistic>))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<MicrosoftDynamicsCRMplugintypestatistic> Value { get; set; }

    }
}
