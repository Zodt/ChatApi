# Checking the presence of a phone number in the ban list
**<span style="color:green">Implementation notes</span>**<br/>
This method is available in both synchronous and asynchronous implementations

## Request
| `Parameter` | `Description`                        | `The data type of the parameter` | `Required parameter` |
|:-----------:|:-------------------------------------|:--------------------------------:|:--------------------:|
|  `Phone`  |  A phone number starting with the country code. <br/>You do not need to add your number. <br/> USA example: 17472822486. | `String` | <ul><li>- [x] </li></ul> |

## Response
| `Parameter`           | `Description`                                           | `The data type of the parameter` | 
|:---------------------:|:--------------------------------------------------------|:--------------------------------:|
|`Phone`| Check the phone number | `String`
|`Banned`| Flag indicating that the phone number being checked will be blocked automatically | `Boolean`
|`Message`| Warning message. <br/> If it is set, a message will be sent before sending the ban. | `String`
|`BanPhoneMask` | Regular expression on which bans on numbers will be sent. | `String`

## Example
```csharp
using System;

using WhatsAppApi.Connect;
using WhatsAppApi.Core.Helpers;

using WhatsAppApi.Core.Connect;
using WhatsAppApi.Core.Connect.Interfaces;

using WhatsAppApi.Messages.Requests;
using WhatsAppApi.Messages.Responses.Interfaces;

using WhatsAppApiClient.Properties;
namespace WhatsAppApiClient
{
    internal class Program
    {
        public static IWhatsAppConnect Connect { get; set; }

        private static void Main()
        {
            // put your chat-api's data
            Connect = new WhatsAppConnect(WhatsApp_Server, WhatsApp_Instance, WhatsApp_Token); 

            var banOperation = new BanOperation(Connect);
            
            IWhatsAppResponse<IBanSettingsResponse?> response = banOperation.CheckBan();
            if (response.IsSuccess) throw response.Exception!;

            var messageResponse = response.GetResult();
            Console.WriteLine(messageResponse!.IsBanned);
        }
    }
}
```
