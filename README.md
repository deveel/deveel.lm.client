# Deveel Client to the LINK Mobility SMS API
A .NET Core client library to connect to the LINK Mobility SMS API, developed in absence of an official one from the provider.

The library is generated using AutoRest, from an OpenAPI document created for this project, based on the definitions provided by LINK Mobility itself: given this model, it is possible to generate client libraries in other languages supported by the generation tool (see [AutoRest](https://github.com/Azure/autorest) for more details).

# Basic Usage

## .NET

### Single Message

``` csharp
using System;

using Microsoft.Rest;

using Deveel.Link;
using Deveel.Link.Models;

namespace Example {
  public class Program {
    public static async Task<int> Main(string[] args) {
      Console.Out.WriteLine("Sending new Message...");
    
      // 1. replace <UserName> and <Password> with the credentials
      // you received from LINK Mobility
      var credentials = new BasicAuthenticationCredentials {
        UserName = "<UserName>",
        Password = "<Password>"
      };
      
      var client = new LinkSmsClient(credentials);
      
      // 2. replace <PlatformId> and <PlatformPartnerId> with the values
      // provided by LINK Mobility
      // 3. replace the "Source" and "Destination" values with your
      // sender and the receiver
      var result = await client.Sms.SendAsync(new SmsMessage {
        Source = "2201",
        SourceTON = TypeOfNumber.SHORTCODE,
        Destination = "+472202100",
        PlatformId = "<PlatformId>",
        PlatformPartnerId = "<PlatformPartnerId>"
      });
      
      if (!result.IsSuccess()) {
        Console.Out.WriteLine($"Message successfully sent - ID {result.MessageId}");
      } else {
        Console.Out.WriteLine($"Error while sending the message - Code {result.ResultCode}");
      }
    }
  }
}

```


# Contributing

## .NET

To contribute to the .NET version of this library simply open pull requests, that will be reviewed

## Other Languages

In case you are looking to leverage the OpenAPI Specification available in this project to generate libraries in other languages supported by AutoRest, please take contact with _antonello at deveel dot com_ to align on the structure of the project and the further contributions.

# References

- **LINK Mobility** - https://linkmobility.com
- **SMS Send REST API** - https://linkmobility.com/wp-content/uploads/2020/07/SMS_REST_API_MT_DLR-1.18.pdf
- **AutoRest** - https://gihub.com/Azure/autorest



**Note**: This project is not affiliated, driven or contributed by by LINK Mobility
