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
    /// ComplexDoubleAttributeMetadata
    /// </summary>
    public partial class MicrosoftDynamicsCRMComplexDoubleAttributeMetadata
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMComplexDoubleAttributeMetadata class.
        /// </summary>
        public MicrosoftDynamicsCRMComplexDoubleAttributeMetadata()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMComplexDoubleAttributeMetadata class.
        /// </summary>
        /// <param name="imeMode">Possible values include: 'Auto', 'Inactive',
        /// 'Active', 'Disabled'</param>
        public MicrosoftDynamicsCRMComplexDoubleAttributeMetadata(string imeMode = default(string), double? maxValue = default(double?), double? minValue = default(double?), int? precision = default(int?))
        {
            ImeMode = imeMode;
            MaxValue = maxValue;
            MinValue = minValue;
            Precision = precision;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'Auto', 'Inactive', 'Active',
        /// 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "ImeMode")]
        public string ImeMode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MaxValue")]
        public double? MaxValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MinValue")]
        public double? MinValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Precision")]
        public int? Precision { get; set; }

    }
}
