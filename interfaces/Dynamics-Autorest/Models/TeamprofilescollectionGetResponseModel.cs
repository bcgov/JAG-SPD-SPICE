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
    /// Collection of teamprofilescollection
    /// </summary>
    public partial class TeamprofilescollectionGetResponseModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// TeamprofilescollectionGetResponseModel class.
        /// </summary>
        public TeamprofilescollectionGetResponseModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// TeamprofilescollectionGetResponseModel class.
        /// </summary>
        public TeamprofilescollectionGetResponseModel(IList<MicrosoftDynamicsCRMteamprofiles> value = default(IList<MicrosoftDynamicsCRMteamprofiles>))
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
        public IList<MicrosoftDynamicsCRMteamprofiles> Value { get; set; }

    }
}