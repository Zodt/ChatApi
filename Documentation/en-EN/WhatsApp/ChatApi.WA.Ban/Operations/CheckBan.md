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

using ChatApi.Core.Connect;
using ChatApi.Core.Connect.Interfaces;
using ChatApi.Core.Response.Interfaces;

using ChatApi.WA.Ban;
using ChatApi.WA.Ban.Requests;
using ChatApi.WA.Ban.Responses.Interfaces;

using ChatApiClient.Properties;
namespace ChatApiClient
{
    internal class Program
    {
        internal static IWhatsAppConnect Connect { get; set; }

        internal static void Main()
        {
            Connect = new WhatsAppConnect(WhatsApp_Server, WhatsApp_Instance, WhatsApp_Token); 
            IBanOperations banOperations = new BanOperations(connect);

            var request = new CheckBanRequest
            {
                Phone = "7(999) 111-11-11"
            };
            IChatApiResponse<ICheckBanResponse?>? chatApiResponse = banOperations.CheckBan(request);
            
            if (!chatApiResponse.IsSuccess) throw chatApiResponse.Exception!;
            var response = chatApiResponse.GetResult();
            
            Console.WriteLine(response?.PrintMembers());
        }
    }
}
```
