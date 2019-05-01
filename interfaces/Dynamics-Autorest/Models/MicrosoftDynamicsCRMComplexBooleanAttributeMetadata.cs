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
    /// ComplexBooleanAttributeMetadata
    /// </summary>
    public partial class MicrosoftDynamicsCRMComplexBooleanAttributeMetadata
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMComplexBooleanAttributeMetadata class.
        /// </summary>
        public MicrosoftDynamicsCRMComplexBooleanAttributeMetadata()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMComplexBooleanAttributeMetadata class.
        /// </summary>
        public MicrosoftDynamicsCRMComplexBooleanAttributeMetadata(bool? defaultValue = default(bool?), string formulaDefinition = default(string), int? sourceTypeMask = default(int?), MicrosoftDynamicsCRMComplexBooleanOptionSetMetadata optionSet = default(MicrosoftDynamicsCRMComplexBooleanOptionSetMetadata))
        {
            DefaultValue = defaultValue;
            FormulaDefinition = formulaDefinition;
            SourceTypeMask = sourceTypeMask;
            OptionSet = optionSet;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DefaultValue")]
        public bool? DefaultValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FormulaDefinition")]
        public string FormulaDefinition { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SourceTypeMask")]
        public int? SourceTypeMask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OptionSet")]
        public MicrosoftDynamicsCRMComplexBooleanOptionSetMetadata OptionSet { get; set; }

    }
}
