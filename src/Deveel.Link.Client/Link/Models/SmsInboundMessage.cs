using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace Deveel.Link.Models {
	public class SmsInboundMessage {
		/// <summary>The shortnumber (prefixed by a two-letter country code) 
		/// the message was sent to</summary>
		[JsonProperty("destination")]
		public string Destination { get; set; }

		[JsonProperty("subNumber")]
		public int? SubNumber { get; set; }

		[JsonProperty("source")]
		public string Source { get; set; }

		[JsonProperty("content")]
		public InboundMessageContent Content { get; set; }

		[JsonProperty("route")]
		public Route Route { get; set; }

		[JsonProperty("operator")]
		public string Operator { get; set; }

		[JsonProperty("timestamp")]
		public DateTime TimeStamp { get; set; }

		[JsonProperty("messageId")]
		public string MessageId { get; set; }

		[JsonProperty("operatorTimestamp")]
		public DateTime? OperatorTimeStamp { get; set; }

		[JsonProperty("operatorMessageId")]
		public string OperatorMessageId { get; set; }

		[JsonProperty("gateCustomParameters")]
		public IDictionary<string, object> GateCustomParameters { get; set; }

		[JsonProperty("customParameters")]
		public IDictionary<string, object> CustomParameters { get; set; }
	}
}
