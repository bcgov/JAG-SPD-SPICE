// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.Spice.Interfaces
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Bookableresourcebookingspicerequiredcheckses.
    /// </summary>
    public static partial class BookableresourcebookingspicerequiredchecksesExtensions
    {
            /// <summary>
            /// Get bookableresourcebooking_spice_requiredcheckses from
            /// bookableresourcebookings
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='bookableresourcebookingid'>
            /// key: bookableresourcebookingid of bookableresourcebooking
            /// </param>
            /// <param name='top'>
            /// </param>
            /// <param name='skip'>
            /// </param>
            /// <param name='search'>
            /// </param>
            /// <param name='filter'>
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='orderby'>
            /// Order items by property values
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMspiceRequiredchecksCollection Get(this IBookableresourcebookingspicerequiredcheckses operations, string bookableresourcebookingid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetAsync(bookableresourcebookingid, top, skip, search, filter, count, orderby, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get bookableresourcebooking_spice_requiredcheckses from
            /// bookableresourcebookings
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='bookableresourcebookingid'>
            /// key: bookableresourcebookingid of bookableresourcebooking
            /// </param>
            /// <param name='top'>
            /// </param>
            /// <param name='skip'>
            /// </param>
            /// <param name='search'>
            /// </param>
            /// <param name='filter'>
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='orderby'>
            /// Order items by property values
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MicrosoftDynamicsCRMspiceRequiredchecksCollection> GetAsync(this IBookableresourcebookingspicerequiredcheckses operations, string bookableresourcebookingid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(bookableresourcebookingid, top, skip, search, filter, count, orderby, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get bookableresourcebooking_spice_requiredcheckses from
            /// bookableresourcebookings
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='bookableresourcebookingid'>
            /// key: bookableresourcebookingid of bookableresourcebooking
            /// </param>
            /// <param name='top'>
            /// </param>
            /// <param name='skip'>
            /// </param>
            /// <param name='search'>
            /// </param>
            /// <param name='filter'>
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='orderby'>
            /// Order items by property values
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse<MicrosoftDynamicsCRMspiceRequiredchecksCollection> GetWithHttpMessages(this IBookableresourcebookingspicerequiredcheckses operations, string bookableresourcebookingid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.GetWithHttpMessagesAsync(bookableresourcebookingid, top, skip, search, filter, count, orderby, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get bookableresourcebooking_spice_requiredcheckses from
            /// bookableresourcebookings
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='bookableresourcebookingid'>
            /// key: bookableresourcebookingid of bookableresourcebooking
            /// </param>
            /// <param name='activityid'>
            /// key: activityid of spice_requiredchecks
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMspiceRequiredchecks RequiredchecksesByKey(this IBookableresourcebookingspicerequiredcheckses operations, string bookableresourcebookingid, string activityid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.RequiredchecksesByKeyAsync(bookableresourcebookingid, activityid, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get bookableresourcebooking_spice_requiredcheckses from
            /// bookableresourcebookings
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='bookableresourcebookingid'>
            /// key: bookableresourcebookingid of bookableresourcebooking
            /// </param>
            /// <param name='activityid'>
            /// key: activityid of spice_requiredchecks
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MicrosoftDynamicsCRMspiceRequiredchecks> RequiredchecksesByKeyAsync(this IBookableresourcebookingspicerequiredcheckses operations, string bookableresourcebookingid, string activityid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RequiredchecksesByKeyWithHttpMessagesAsync(bookableresourcebookingid, activityid, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get bookableresourcebooking_spice_requiredcheckses from
            /// bookableresourcebookings
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='bookableresourcebookingid'>
            /// key: bookableresourcebookingid of bookableresourcebooking
            /// </param>
            /// <param name='activityid'>
            /// key: activityid of spice_requiredchecks
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse<MicrosoftDynamicsCRMspiceRequiredchecks> RequiredchecksesByKeyWithHttpMessages(this IBookableresourcebookingspicerequiredcheckses operations, string bookableresourcebookingid, string activityid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.RequiredchecksesByKeyWithHttpMessagesAsync(bookableresourcebookingid, activityid, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

    }
}