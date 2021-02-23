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
            
            var banSettings = new BanSettingRequest()
            {
                BanPhoneMask = @"^\\(?([0-9]{3})\\)?[-.●]?([0-9]{3})[-.●]?([0-9]{4})$",
                PreBanMessage = @"Do not write to me, otherwise I will send you a ban"
            };
            
            IWhatsAppResponse<IBanSettingsResponse?> response = banOperation.SetBanSettings(banSettings);
            if (response.IsSuccess) throw response.Exception!;

            var messageResponse = response.GetResult();
            Console.WriteLine(messageResponse!.IsSet);
        }
    }
}
```
