using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;

using Deveel.Link.Models;

namespace Deveel.Link.Util {
	public static class InboundMessageParser {
		public static Task<SmsInboundMessage> ParseInboundMessageAsync(HttpRequestMessage request)
			=> ParseInboundMessageAsync(request, CancellationToken.None);

		public static async Task<SmsInboundMessage> ParseInboundMessageAsync(HttpRequestMessage request, CancellationToken cancellationToken) {
			var stream = await request.Content.ReadAsStreamAsync();
			if (stream == null)
				return null;

			return await ParseInboundMessageAsync(stream, cancellationToken);
		}

		public static Task<SmsInboundMessage> ParseInboundMessageAsync(Stream inputStream)
			=> ParseInboundMessageAsync(inputStream, CancellationToken.None);

		public static Task<SmsInboundMessage> ParseInboundMessageAsync(Stream inputStream, CancellationToken cancellationToken)
			=> JsonParserUtil.ParseAsync<SmsInboundMessage>(inputStream, cancellationToken);
	}
}
