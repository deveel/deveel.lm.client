using System;

namespace Deveel.Link.Models {
	public partial class SmsMessageRequest : ISmsMessage, IParametrized {
		public DateTime? ScheduledTime {
			get => this.GetParameterValue<DateTime?>(KnownCustomParameters.ScheduledTime, null);
			set => this.SetParameterValue(KnownCustomParameters.ScheduledTime, value);
		}
	}
}
