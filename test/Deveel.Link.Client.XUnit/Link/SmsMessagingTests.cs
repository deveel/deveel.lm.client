using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

using Deveel.Link.Models;

using Microsoft.Rest;

using Newtonsoft.Json.Linq;

using Xunit;

namespace Deveel.Link {
	public class SmsMessagingTests {
		[Fact]
		public async Task SendSingleMessage_Queued() {
			// setup the test http client to intercept the call
			var httpClient = HttpClientUtil.CreateTestClient(request => {
				var resultJson = JObject.FromObject(new SmsSendResult {
					ResultCode = ResultCodes.Queued,
					Description = "Queued",
					MessageId = Guid.NewGuid().ToString("N")
				});

				return new HttpResponseMessage(HttpStatusCode.OK) {
					Content = new StringContent(resultJson.ToString(), Encoding.UTF8)
				};
			});


			var pid = Guid.NewGuid().ToString("N");
			var ppid = Guid.NewGuid().ToString("N");

			var client = new LinkClient(new BasicAuthenticationCredentials {
				UserName = "user1",
				Password = "pwd1"
			}, httpClient, true);

			var result = await client.Sms.SendAsync(new SmsMessageRequest {
				Source = "2234",
				SourceTON = TypeOfNumber.SHORTCODE,
				Destination = "+472230330",
				UserData = "Hello! This is a new test SMS...",
				PlatformId = pid,
				PlatformPartnerId = ppid
			});

			Assert.NotNull(result);
			Assert.True(result.IsSuccessful);
			Assert.Equal(ResultCodes.Queued, result.ResultCode);
		}

		[Fact]
		public async Task SendSingleMessage_MissingPlatformId() {
			// setup the test http client to intercept the call (although it should never be reached...)
			var httpClient = HttpClientUtil.CreateTestClient(request => {
				var resultJson = JObject.FromObject(new SmsSendResult {
					ResultCode = ResultCodes.InvalidMessageContent,
					Description = "Missing Platform ID",
				});

				return new HttpResponseMessage(HttpStatusCode.BadRequest) {
					Content = new StringContent(resultJson.ToString(), Encoding.UTF8)
				};
			});

			var client = new LinkClient(new BasicAuthenticationCredentials {
				UserName = "user1",
				Password = "pwd1"
			}, httpClient, true);

			var ex = await Assert.ThrowsAsync<ValidationException>(() => client.Sms.SendAsync(new SmsMessageRequest {
				Source = "2234",
				SourceTON = TypeOfNumber.SHORTCODE,
				Destination = "+472230330",
				UserData = "Hello! This is a new test SMS..."
			}));

			Assert.NotNull(ex);
			Assert.Equal("cannot be null", ex.Rule);
			Assert.Equal("PlatformId", ex.Target);
		}

		[Fact]
		public async Task SendBatch_AllQueued() {
			// setup the test http client to intercept the call
			var httpClient = HttpClientUtil.CreateTestClient(request => {
				var resultJson = JArray.FromObject(new SmsSendResult[] {
					new SmsSendResult {
						ResultCode = ResultCodes.Queued,
						Description = "Queued",
						MessageId = Guid.NewGuid().ToString("N")
					}
				});

				return new HttpResponseMessage(HttpStatusCode.OK) {
					Content = new StringContent(resultJson.ToString(), Encoding.UTF8)
				};
			});


			var pid = Guid.NewGuid().ToString("N");
			var ppid = Guid.NewGuid().ToString("N");

			var client = new LinkClient(new BasicAuthenticationCredentials {
				UserName = "user1",
				Password = "pwd1"
			}, httpClient, true);

			var results = await client.Sms.BatchSendAsync(new SmsBatchSendRequest {
				PlatformId = pid,
				PlatformPartnerId = ppid,
				SendRequestMessages = new List<SmsBatchMessage> {
					new SmsBatchMessage {
						Source = "2234",
						SourceTON = TypeOfNumber.SHORTCODE,
						Destination = "+476995005"
					}
				}
			});

			Assert.NotNull(results);
			Assert.NotEmpty(results);
			Assert.Single(results);
			Assert.True(results[0].IsSuccessful);
			Assert.Equal(ResultCodes.Queued, results[0].ResultCode);
		}
	}
}
