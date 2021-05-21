[![Build](https://github.com/deveel/deveel.lm.client/actions/workflows/lm-client-cd.yml/badge.svg)](https://github.com/deveel/deveel.lm.client/actions/workflows/lm-client-cd.yml)

# LINK Mobility REST API Client
This is a .NET Core client library to connect to the LINK Mobility SMS API, developed in absence of an official one from the provider.

The library is generated using **AutoRest**, from an _OpenAPI_ specification document created for this project (in absence of an official one from LINK Mobility itself), based on the public [documentation of the LINK Mobility REST APIs](https://linkmobility.com/developer/): since this approach chosen for the development, it would be possible to generate client libraries in other languages supported by the generation tool (eg. python, go, typescript, etc.).

# Pre-Requisites

Before you can use this library, you must receive the following parameters from **LINK Mobility**: take contact with the Support services of the company to obtain them.

| Parameter                 | Required  | Description                                                    |
|---------------------------|-----------|----------------------------------------------------------------|
| **Platform ID**           |     X     | Identifies a platform from where the functions are accessed    |
| **Platform Partner ID**   |     X     | The unique identifier of the account within the Platform       |
| **User Name**             |     X     | The name of the user accessing the functions of the API        |
| **Password**              |     X     | A secret password used to authenticate the user                |
| **Platform Service Type** |     -     | The type of service within the Platform that is using the APIs |
| **Platform Service ID**   |     -     | The unique identifier of the service                           |
| **Gate IDs** *            |     -     | One or more identifiers of Gates (HTTP callbacks)              |

## * Gates
Gates must be configured by LINK Mobility and callback one or more URLs that you will chose: their identifiers (_Gate ID_) can be specified in the single messages or in  the batches of messages, to hint LINK Mobility on the destination of the callbacks for the notification of the status of deliver (_Delivery Report_ or _DLR_) of the individual message.

These callbacks are also providing the receiver inbound messages (_Mobile Originated_ or _MO_) directed to a number and optionally configured to a given routing logic (_MO Route_ or  _Keyword Route_).

# Installation

## NuGet Package for .NET Project

### Pre-releases

Before adding a pre-release package you need to add Deveel's GitHub NuGet repository, where the latest builds are stored  

``` powershell
PS C:\dev\link.example>  dotnet nuget add source "https://nuget.pkg.github.com/deveel/index.json" -n "Deveel NuGet"
PS C:\dev\link.example> dotnet add ./src/Link.Example.csproj package Deveel.Link.Client --prerelease
```

### NuGet.com

**TODO**: ...

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
      
      var client = new LinkSmsClient(LinkNodes.General, credentials);
      
      // 2. replace <PlatformId> and <PlatformPartnerId> with the values
      // provided by LINK Mobility
      // 3. replace the "Source" and "Destination" values with your
      // sender and the receiver
      var result = await client.Sms.SendAsync(new SmsMessageRequest {
        Source = "2201",
        SourceTON = TypeOfNumber.SHORTCODE,
        Destination = "+472202100",
        PlatformId = "<PlatformId>",
        PlatformPartnerId = "<PlatformPartnerId>"
      });
      
      if (!result.IsSuccessful) {
        Console.Out.WriteLine($"Message successfully sent - ID {result.MessageId}");
        return 0;
      } else {
        Console.Out.WriteLine($"Error while sending the message - Code {result.ResultCode}");
        return -1;
      }
    }
  }
}

```

### Batch Messaging


``` csharp
using System;

using Microsoft.Rest;

using Deveel.Link;
using Deveel.Link.Models;

namespace Example {
  public class Program {
    public static async Task<int> Main(string[] args) {
      Console.Out.WriteLine("Sending a simple batch of Messages...");
    
      // 1. replace <UserName> and <Password> with the credentials
      // you received from LINK Mobility
      var credentials = new BasicAuthenticationCredentials {
        UserName = "<UserName>",
        Password = "<Password>"
      };
      
      var client = new LinkSmsClient(LinkNodes.General, credentials);
      
      // 2. replace <PlatformId> and <PlatformPartnerId> with the values
      // provided by LINK Mobility
      // 3. replace the "Source" and "Destination" values with your
      // sender and the receiver
      var result = await client.Sms.BatchSendAsync(new SmsBatchSendRequest {
        PlatformId = "<PlatformId>",
        PlatformPartnerId = "<PlatformPartnerId>"
        SendRequestMessages = new List<SmsBatchMessage> {
          new SmsBatchMessage {
            Source = "2201",
            SourceTON = TypeOfNumber.SHORTCODE,
            Destination = "+472202100"
          }
        }
      });
      
      var failed = result.Where(r => !r.IsSuccessful);
      
      if (!failed.Any()) {
        Console.Out.WriteLine("All  messages were successfully sent");
        return 0;
      } else {
        Console.Out.WriteLine($"Some of the messages failed to be sent");
        return -1;
      }
    }
  }
}

```


# Contributing

## .NET

To contribute to the .NET version of this library simply open pull requests, that will be reviewed

## Other Frameworks

In case you are looking to leverage the OpenAPI Specification available in this project to generate libraries in other languages and frameworks (eg. go, python, typescript, etc.) supported by AutoRest, please take contact with _antonello at deveel dot com_ to align on the structure of the project and the further contributions.

# References

- **LINK Mobility** - https://linkmobility.com
- **SMS Send REST API** - https://linkmobility.com/wp-content/uploads/2020/07/SMS_REST_API_MT_DLR-1.18.pdf
- **AutoRest** - https://gihub.com/Azure/autorest



**Note**: This project is not affiliated, driven or contributed by LINK Mobility
