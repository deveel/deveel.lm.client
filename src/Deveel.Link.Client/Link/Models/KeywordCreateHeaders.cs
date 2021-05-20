// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Deveel.Link.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines headers for create operation.
    /// </summary>
    public partial class KeywordCreateHeaders
    {
        /// <summary>
        /// Initializes a new instance of the KeywordCreateHeaders class.
        /// </summary>
        public KeywordCreateHeaders()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the KeywordCreateHeaders class.
        /// </summary>
        /// <param name="location">The URL location where the newly created
        /// route is accessible</param>
        public KeywordCreateHeaders(string location = default(string))
        {
            Location = location;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the URL location where the newly created route is
        /// accessible
        /// </summary>
        [JsonProperty(PropertyName = "Location")]
        public string Location { get; set; }

    }
}