using System;

namespace Deveel.Link.Models {
	public partial class SmsSendResult {
		// The result of a send should not indicate other statuses...
		public bool IsSuccessful => ResultCode == ResultCodes.Queued ||
									ResultCode == ResultCodes.SentToOperator;
	}
}
