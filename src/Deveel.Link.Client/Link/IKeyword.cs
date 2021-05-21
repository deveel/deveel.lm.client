// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Deveel.Link
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Keyword operations.
    /// </summary>
    public partial interface IKeyword
    {
        /// <summary>
        /// Creates a new Keyword Route
        /// </summary>
        /// <remarks>
        /// Adds a keyword data to the storage by posting a keyword object
        /// </remarks>
        /// <param name='body'>
        /// </param>
        /// <param name='number'>
        /// The number that the keyword will be routed to
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<object,KeywordCreateHeaders>> CreateWithHttpMessagesAsync(Route body, string number, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a Keyword Route by ID
        /// </summary>
        /// <remarks>
        /// Retrieves a keyword route from a partner by its id
        /// </remarks>
        /// <param name='number'>
        /// The number that the keywords are routed to
        /// </param>
        /// <param name='platformId'>
        /// The ID of the Platform assigned by LINK Mobility
        /// </param>
        /// <param name='partnerId'>
        /// The ID of the Partner assigned by LINK Mobility
        /// </param>
        /// <param name='id'>
        /// The ID of the Route to be returned
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<object>> GetWithHttpMessagesAsync(string number, string platformId, string partnerId, string id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a Keyword Route by a Reference ID
        /// </summary>
        /// <param name='number'>
        /// The number that the keywords are routed to
        /// </param>
        /// <param name='platformId'>
        /// The ID of the Platform assigned by LINK Mobility
        /// </param>
        /// <param name='partnerId'>
        /// The ID of the Partner assigned by LINK Mobility
        /// </param>
        /// <param name='refid'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<object>> GetByRefIdWithHttpMessagesAsync(string number, string platformId, string partnerId, string refid, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
