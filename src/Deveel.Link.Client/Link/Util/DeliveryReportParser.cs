using System;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

using Deveel.Link.Client.Link.Models;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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

			public static async Task<SmsDeliveryReport> ParseDeliveryReportAsync(Stream inputStream, CancellationToken cancellationToken) {
			if (inputStream is null)
				throw new ArgumentNullException(nameof(inputStream));
			if (!inputStream.CanRead)
				throw new ArgumentException("The input stream is not readable");

			JToken json;

			using (var reader = new StreamReader(inputStream)) {
				using (var jsonReader = new JsonTextReader(reader)) {
					json = await JToken.ReadFromAsync(jsonReader, cancellationToken);
				}
			}

			return json.ToObject<SmsDeliveryReport>();
		}
	}
}
