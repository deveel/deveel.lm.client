using System;

using Newtonsoft.Json;

namespace Deveel.Link.Models {
	public class InboundMessageContent {
		[JsonProperty("type")]
		public string Type { get; set; }

		[JsonProperty("userData")]
		public string UserData { get; set; }

		[JsonProperty("encoding")]
		public string Encoding { get; set; }
	}
}
