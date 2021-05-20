using System;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

using Deveel.Link.Models;

namespace Deveel.Link.Util {
	public static class DeliveryReportParser {
		public static Task<SmsDeliveryReport> ParseDeliveryReportAsync(HttpRequestMessage request)
			=> ParseDeliveryReportAsync(request, CancellationToken.None);

		public static async Task<SmsDeliveryReport> ParseDeliveryReportAsync(HttpRequestMessage request, CancellationToken cancellationToken) {
			var stream = await request.Content.ReadAsStreamAsync();
			if (stream == null)
				return null;

			return await ParseDeliveryReportAsync(stream, cancellationToken);
		}

		public static Task<SmsDeliveryReport> ParseDeliveryReportAsync(Stream inputStream)
			=> ParseDeliveryReportAsync(inputStream, CancellationToken.None);

		public static Task<SmsDeliveryReport> ParseDeliveryReportAsync(Stream inputStream, CancellationToken cancellationToken)
			=> JsonParserUtil.ParseAsync<SmsDeliveryReport>(inputStream, cancellationToken);
	}
}
