using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace Deveel.Link.Models {
	public class InboundMessageRoute {
		[JsonProperty("type")]
		public string Type { get; set; }

		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("refId")]
		public string RefId { get; set; }

		[JsonProperty("gateIds")]
		public IList<string> GateIDs { get; set; }

		[JsonProperty("platformId")]
		public string PlatformId { get; set; }

		[JsonProperty("platformPartnerId")]
		public string PlatformPartnerId { get; set; }

		[JsonProperty("platformServiceType")]
		public string PlatformServiceType { get; set; }

		[JsonProperty("platformServiceId")]
		public string PlatformServiceId { get; set; }

		[JsonProperty("number")]
		public string Number { get; set; }

		[JsonProperty("startRange")]
		public string StartRange { get; set; }

		[JsonProperty("stopRange")]
		public string StopRange { get; set; }

		[JsonProperty("keyword")]
		public string Keyword { get; set; }

		[JsonProperty("keywordType")]
		public string KeywordType { get; set; }

		[JsonProperty("active")]
		public bool? Active { get; set; }

		[JsonProperty("start")]
		public DateTime? Start { get; set; }

		[JsonProperty("end")]
		public DateTime? End { get; set; }

		[JsonProperty("shared")]
		public bool? Shared { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }
	}
}
