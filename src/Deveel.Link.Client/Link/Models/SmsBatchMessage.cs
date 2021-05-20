// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Deveel.Link.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A single message within a batch
    /// </summary>
    public partial class SmsBatchMessage
    {
        /// <summary>
        /// Initializes a new instance of the SmsBatchMessage class.
        /// </summary>
        public SmsBatchMessage()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SmsBatchMessage class.
        /// </summary>
        /// <param name="source"> This is the source number from where the
        /// message should be sent</param>
        /// <param name="destination">This is the destination number</param>
        /// <param name="sourceTON">This is the source type of number. See
        /// allowed TON values below. Possible values include: 'ALPHANUMERIC',
        /// 'SHORTCODE', 'MSISDN'</param>
        /// <param name="destinationTON">This is the destination type of
        /// number. Possible values include: 'ALPHANUMERIC', 'SHORTCODE',
        /// 'MSISDN'</param>
        /// <param name="dcs">This is the Data Coding Scheme that should be
        /// used when sending the SMS. Possible values include: 'BINARY',
        /// 'GSM', 'TEXT', 'UC2'</param>
        /// <param name="userDataHeader">This value may be specified when
        /// sending concatenated SMS, WAP-push, etc. The format is hex encoded
        /// 8-bit bytes</param>
        /// <param name="userData">This is the message content itself. The DCS
        /// specifies the format (encoding) on this value</param>
        /// <param name="priority">Specifies the priority to be given to the
        /// message. Possible values include: 'HIGH', 'NORMAL', 'LOW'</param>
        /// <param name="age">Allowed age for (adult) content</param>
        /// <param name="productDescription">When sending premium messages, a
        /// description of the service</param>
        /// <param name="productCategory">When sending premium messages,
        /// specify which category the service is</param>
        /// <param name="tariff">Price, in local currency, in 1/100 of
        /// currency</param>
        /// <param name="currency">The currency should be set if the default
        /// country currency not to be used. Possible values include: 'NOK',
        /// 'DKK', 'SEK', 'EUR'</param>
        /// <param name="moReferenceId">A reference to the ID of the MO message
        /// which triggered the MT message</param>
        public SmsBatchMessage(string source, string destination, string sourceTON = default(string), string destinationTON = default(string), string dcs = default(string), string userDataHeader = default(string), string userData = default(string), string priority = default(string), int? age = default(int?), string productDescription = default(string), int? productCategory = default(int?), int? tariff = default(int?), string currency = default(string), string moReferenceId = default(string))
        {
            Source = source;
            SourceTON = sourceTON;
            Destination = destination;
            DestinationTON = destinationTON;
            Dcs = dcs;
            UserDataHeader = userDataHeader;
            UserData = userData;
            Priority = priority;
            Age = age;
            ProductDescription = productDescription;
            ProductCategory = productCategory;
            Tariff = tariff;
            Currency = currency;
            MoReferenceId = moReferenceId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets  This is the source number from where the message
        /// should be sent
        /// </summary>
        [JsonProperty(PropertyName = "source")]
        public string Source { get; set; }

        /// <summary>
        /// Gets or sets this is the source type of number. See allowed TON
        /// values below. Possible values include: 'ALPHANUMERIC', 'SHORTCODE',
        /// 'MSISDN'
        /// </summary>
        [JsonProperty(PropertyName = "sourceTON")]
        public string SourceTON { get; set; }

        /// <summary>
        /// Gets or sets this is the destination number
        /// </summary>
        [JsonProperty(PropertyName = "destination")]
        public string Destination { get; set; }

        /// <summary>
        /// Gets or sets this is the destination type of number. Possible
        /// values include: 'ALPHANUMERIC', 'SHORTCODE', 'MSISDN'
        /// </summary>
        [JsonProperty(PropertyName = "destinationTON")]
        public string DestinationTON { get; set; }

        /// <summary>
        /// Gets or sets this is the Data Coding Scheme that should be used
        /// when sending the SMS. Possible values include: 'BINARY', 'GSM',
        /// 'TEXT', 'UC2'
        /// </summary>
        [JsonProperty(PropertyName = "dcs")]
        public string Dcs { get; set; }

        /// <summary>
        /// Gets or sets this value may be specified when sending concatenated
        /// SMS, WAP-push, etc. The format is hex encoded 8-bit bytes
        /// </summary>
        [JsonProperty(PropertyName = "userDataHeader")]
        public string UserDataHeader { get; set; }

        /// <summary>
        /// Gets or sets this is the message content itself. The DCS specifies
        /// the format (encoding) on this value
        /// </summary>
        [JsonProperty(PropertyName = "userData")]
        public string UserData { get; set; }

        /// <summary>
        /// Gets or sets specifies the priority to be given to the message.
        /// Possible values include: 'HIGH', 'NORMAL', 'LOW'
        /// </summary>
        [JsonProperty(PropertyName = "priority")]
        public string Priority { get; set; }

        /// <summary>
        /// Gets or sets allowed age for (adult) content
        /// </summary>
        [JsonProperty(PropertyName = "age")]
        public int? Age { get; set; }

        /// <summary>
        /// Gets or sets when sending premium messages, a description of the
        /// service
        /// </summary>
        [JsonProperty(PropertyName = "productDescription")]
        public string ProductDescription { get; set; }

        /// <summary>
        /// Gets or sets when sending premium messages, specify which category
        /// the service is
        /// </summary>
        [JsonProperty(PropertyName = "productCategory")]
        public int? ProductCategory { get; set; }

        /// <summary>
        /// Gets or sets price, in local currency, in 1/100 of currency
        /// </summary>
        [JsonProperty(PropertyName = "tariff")]
        public int? Tariff { get; set; }

        /// <summary>
        /// Gets or sets the currency should be set if the default country
        /// currency not to be used. Possible values include: 'NOK', 'DKK',
        /// 'SEK', 'EUR'
        /// </summary>
        [JsonProperty(PropertyName = "currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or sets a reference to the ID of the MO message which
        /// triggered the MT message
        /// </summary>
        [JsonProperty(PropertyName = "moReferenceId")]
        public string MoReferenceId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Source == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Source");
            }
            if (Destination == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Destination");
            }
        }
    }
}