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
    /// SearchResults
    /// </summary>
    public partial class MicrosoftDynamicsCRMSearchResults
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMSearchResults
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMSearchResults()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMSearchResults
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMSearchResults(IList<MicrosoftDynamicsCRMAppointmentProposal> proposals = default(IList<MicrosoftDynamicsCRMAppointmentProposal>), MicrosoftDynamicsCRMTraceInfo traceInfo = default(MicrosoftDynamicsCRMTraceInfo))
        {
            Proposals = proposals;
            TraceInfo = traceInfo;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Proposals")]
        public IList<MicrosoftDynamicsCRMAppointmentProposal> Proposals { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TraceInfo")]
        public MicrosoftDynamicsCRMTraceInfo TraceInfo { get; set; }

    }
}