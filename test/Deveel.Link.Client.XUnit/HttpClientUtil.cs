using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;

using Moq.Protected;

using Moq;
using System.Reflection.Metadata.Ecma335;

namespace Deveel {
	public static class HttpClientUtil {
		public static HttpClient CreateTestClient(IHttpRequestCallback callback) {
			var handler = new Mock<HttpMessageHandler>();
			handler.Protected().Setup<Task<HttpResponseMessage>>("SendAsync",
					ItExpr.IsAny<HttpRequestMessage>(),
					ItExpr.IsAny<CancellationToken>())
			.Returns((HttpRequestMessage request, CancellationToken token) => callback.RequestAsync(request, token));

			return new HttpClient(handler.Object);
		}

		public static HttpClient CreateTestClient(Func<HttpRequestMessage, CancellationToken, Task<HttpResponseMessage>> callback)
			=> CreateTestClient(new AsyncRequestCallback(callback));

		public static HttpClient CreateTestClient(Func<HttpRequestMessage, HttpResponseMessage> func)
			=> CreateTestClient(new SyncRequestCallback(func));

		#region AsyncRequestCallback

		class AsyncRequestCallback : IHttpRequestCallback {
			private readonly Func<HttpRequestMessage, CancellationToken, Task<HttpResponseMessage>> func;

			public AsyncRequestCallback(Func<HttpRequestMessage, CancellationToken, Task<HttpResponseMessage>> func) {
				this.func = func;
			}

			public Task<HttpResponseMessage> RequestAsync(HttpRequestMessage request, CancellationToken cancellationToken) 
				=> func(request, cancellationToken);
		}

		#endregion

		#region SyncRequestCallback

		class SyncRequestCallback : IHttpRequestCallback {
			private readonly Func<HttpRequestMessage, HttpResponseMessage> func;

			public SyncRequestCallback(Func<HttpRequestMessage, HttpResponseMessage> func) {
				this.func = func;
			}

			public Task<HttpResponseMessage> RequestAsync(HttpRequestMessage request, CancellationToken cancellationToken) {
				var response = func(request);
				return Task.FromResult(response);
			}
		}

		#endregion
	}
}
