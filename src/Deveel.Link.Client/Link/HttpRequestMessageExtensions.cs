using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

using Deveel.Link.Models;
using Deveel.Link.Util;

namespace Deveel.Link {
	public static class HttpRequestMessageExtensions {
		public static Task<SmsDeliveryReport> AsDeliveryReportAsync(this HttpRequestMessage request, CancellationToken cancellationToken)
			=> DeliveryReportParser.ParseDeliveryReportAsync(request, cancellationToken);

		public static Task<SmsDeliveryReport> AsDeliveryReportAsync(this HttpRequestMessage request)
			=> DeliveryReportParser.ParseDeliveryReportAsync(request);

		public static Task<SmsInboundMessage> AsInboundMessageAsync(this HttpRequestMessage request, CancellationToken cancellationToken)
			=> InboundMessageParser.ParseInboundMessageAsync(request, cancellationToken);

		public static Task<SmsInboundMessage> AsInboundMessageAsync(this HttpRequestMessage request)
			=> InboundMessageParser.ParseInboundMessageAsync(request);
	}
}
