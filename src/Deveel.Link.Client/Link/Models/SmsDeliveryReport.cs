using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace Deveel.Link.Client.Link.Models {
	public class SmsDeliveryReport {
		[JsonProperty("refId")]
		public string RefId { get; set; }

		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("operator")]
		public string Operator { get; set; }

		[JsonProperty("sendTimestamp")]
		public DateTime SentTimeStamp { get; set; }

		[JsonProperty("timestamp")]
		public DateTime TimeStamp { get; set; }

		[JsonProperty("resultCode")]
		public int ResultCode { get; set; }

		[JsonProperty("operatorResultCode")]
		public string OperatorResultCode { get; set; }

		[JsonProperty("segments")]
		public int Segments { get; set; }

		[JsonProperty("gateCustomParameters")]
		public IDictionary<string, object> GateCustomParameters { get; set; }

		[JsonProperty("customParameters")]
		public IDictionary<string, object> CustomParameters { get; set; }
	}
}
