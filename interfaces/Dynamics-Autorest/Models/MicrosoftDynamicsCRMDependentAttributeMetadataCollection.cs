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
    /// DependentAttributeMetadataCollection
    /// </summary>
    public partial class MicrosoftDynamicsCRMDependentAttributeMetadataCollection
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMDependentAttributeMetadataCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMDependentAttributeMetadataCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMDependentAttributeMetadataCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMDependentAttributeMetadataCollection(IList<MicrosoftDynamicsCRMDependentAttributeMetadata> dependentAttributes = default(IList<MicrosoftDynamicsCRMDependentAttributeMetadata>))
        {
            DependentAttributes = dependentAttributes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DependentAttributes")]
        public IList<MicrosoftDynamicsCRMDependentAttributeMetadata> DependentAttributes { get; set; }

    }
}
