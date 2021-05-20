using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Deveel {
	public interface IHttpRequestCallback {
		Task<HttpResponseMessage> RequestAsync(HttpRequestMessage request, CancellationToken cancellationToken);
	}
}
