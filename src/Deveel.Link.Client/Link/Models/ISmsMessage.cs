using System;

namespace Deveel.Link.Models {
	public interface ISmsMessage {
		string Source { get; set; }

		string Destination { get; set; }

		string UserData { get; set; }
	}
}
