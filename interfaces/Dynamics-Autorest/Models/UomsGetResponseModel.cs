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
    /// Collection of uoms
    /// </summary>
    public partial class UomsGetResponseModel
    {
        /// <summary>
        /// Initializes a new instance of the UomsGetResponseModel class.
        /// </summary>
        public UomsGetResponseModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UomsGetResponseModel class.
        /// </summary>
        public UomsGetResponseModel(IList<MicrosoftDynamicsCRMuom> value = default(IList<MicrosoftDynamicsCRMuom>))
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
        public IList<MicrosoftDynamicsCRMuom> Value { get; set; }

    }
}
