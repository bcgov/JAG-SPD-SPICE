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
    /// QuickFindResult
    /// </summary>
    public partial class MicrosoftDynamicsCRMQuickFindResult
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMQuickFindResult class.
        /// </summary>
        public MicrosoftDynamicsCRMQuickFindResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMQuickFindResult class.
        /// </summary>
        public MicrosoftDynamicsCRMQuickFindResult(int? errorCode = default(int?), IList<string> queryColumnSet = default(IList<string>), IList<object> data = default(IList<object>))
        {
            ErrorCode = errorCode;
            QueryColumnSet = queryColumnSet;
            Data = data;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ErrorCode")]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "QueryColumnSet")]
        public IList<string> QueryColumnSet { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Data")]
        public IList<object> Data { get; set; }

    }
}
