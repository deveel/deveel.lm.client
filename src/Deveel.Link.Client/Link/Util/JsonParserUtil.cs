using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Deveel.Link.Util {
	static class JsonParserUtil {
		public static async Task<T> ParseAsync<T>(Stream inputStream, CancellationToken cancellationToken) {
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

			return json.ToObject<T>();
		}
	}
}
