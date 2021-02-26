# Changing the current auto-lock settings
**<span style="color:green">Implementation notes</span>**<br/>
This method is available in both synchronous and asynchronous implementations

## Request
| `Parameter` | `Description`                        | `The data type of the parameter` | `Required parameter` |
|:-----------:|:-------------------------------------|:--------------------------------:|:--------------------:|
|`Set`          | Flag indicating that the current request has changed ban settings. | `Boolean` | <ul><li>- [x] </li></ul> |
|`BanPhoneMask` | Regular expression on which bans on numbers will be sent. | `String`| <ul><li>- [x] </li></ul> |
|`PreBanMessage`| Warning message. <br/> If it is set, a message will be sent before sending the ban. | `String`| <ul><li>- [x] </li></ul> |

## Response
| `Parameter`           | `Description`                                           | `The data type of the parameter` | 
|:---------------------:|:--------------------------------------------------------|:--------------------------------:|
|`Set`          | Flag indicating that the current request has changed ban settings. | `Boolean`
|`BanPhoneMask` | Regular expression on which bans on numbers will be sent. | `String`
|`PreBanMessage`| Warning message. <br/> If it is set, a message will be sent before sending the ban. | `String`

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
            // put your chat-api's data
            Connect = new WhatsAppConnect(WhatsApp_Server, WhatsApp_Instance, WhatsApp_Token); 
            IBanOperations banOperations = new BanOperations(Connect);
            
            var banSettings = new BanSettingRequest()
            {
                BanPhoneMask = @"^\\(?([0-9]{3})\\)?[-.●]?([0-9]{3})[-.●]?([0-9]{4})$",
                PreBanMessage = @"Do not write to me, otherwise I will send you a ban"
            };
            
            IChatApiResponse<IBanSettingsResponse?> chatApiResponse = banOperation.SetBanSettings(banSettings);
            if (!chatApiResponse.IsSuccess) throw chatApiResponse.Exception!;

            IBanSettingsResponse? response = chatApiResponse.GetResult();
            Console.WriteLine(response?.PrintMembers());
        }
    }
}
```
