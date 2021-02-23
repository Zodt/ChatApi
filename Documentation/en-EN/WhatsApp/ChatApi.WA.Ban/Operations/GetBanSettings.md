# Getting the auto-lock setting
**<span style="color:green">Implementation notes</span>**<br/>
This method is available in both synchronous and asynchronous implementations

## Response
| `Parameter` | `Description`                        | `The data type of the parameter` | 
|:-----------:|:-------------------------------------|:--------------------------------:|
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
            
            IWhatsAppResponse<IBanSettingsResponse?> response = banOperation.GetBanSettings();
            if (response.IsSuccess) throw response.Exception!;

            var messageResponse = response.GetResult();
            Console.WriteLine(messageResponse!.BanPhoneMask);
        }
    }
}
```
