# Getting your account settings.
**<span style="color:green">Implementation notes</span>**<br/>
This method is available in both synchronous and asynchronous implementations

## Response
| `Parameter`           | `Description`                                           | `The data type of the parameter` | 
|:---------------------:|:--------------------------------------------------------|:--------------------------------:|
|  `SendDelay`  | Delay in seconds between receive request and sending message. | `Integer` |
|  `WebhookUrl`  | Http or https URL for receiving notifications. | `String` |
|  `InstanceStatuses`  | Turn on/off collecting instance status changing history. | `Boolean` |
|  `WebhookStatuses`  | Turn on/off collecting messages webhooks statuses. | `Boolean` |
|  `StatusNotificationsOn`  | Turn on/off instance changing status notifications in webhooks. | `Boolean` |
|  `AckNotificationsOn`  | Turn on/off ack (message delivered and message viewed) notifications in webhooks. GET method works for the same address. | `Boolean` |
|  `ChatUpdateOn`  | Turn on/off chat update notifications in webhooks. GET method works for the same address. | `Boolean` |
|  `VideoUploadOn`  | Turn on/off receiving video messages. | `Boolean` |
|  `Proxy`  | Socks5 IP address and port proxy for instance. <br/> IMPORTANT! A non-working proxy will cause the account to stop working. | `String` |
|  `GuaranteedHooks`  | Guarantee webhook delivery. Each webhook will make 20 attempts to send until it receives 200 status from the server. | `Boolean` |
|  `IgnoreOldMessages`  | Do not send webhooks with old messages (receiver 5 minutes or oldMessagesPeriod seconds later). | `Boolean` |
|  `OldMessagesPeriod`  | The period in seconds after which the message is considered old. | `Integer` |
|  `ProcessArchive`  | Process messages from archived chats. | `Boolean` |
|  `DisableDialogsArchive`  | Turn on/off dialogs archiving (can slow down instance). | `Boolean` |
|  `ParallelHooks`  | Turn on/off parallel webhook sending. | `Boolean` |

## Example
```csharp
using System;

using ChatApi.Core.Connect;
using ChatApi.Core.Connect.Interfaces;

using ChatApi.WA.Account;
using ChatApi.WA.Account.Requests;

using ChatApiClient.Properties;
namespace ChatApiClient
{
    internal class Program
    {
        public static IWhatsAppConnect Connect { get; set; }

        private static void Main()
        {
            // put your chat-api's data
            Connect = new WhatsAppConnect(WhatsApp_Server, WhatsApp_Instance, WhatsApp_Token); 
            IAccountOperation accountOperation = new AccountOperation(connect);

            var accountSettingsRequest = new AccountSettingsRequest
            {
                SendDelay = 2
            };
            var chatApiResponse = accountOperation.ChangeSettings(accountSettingsRequest);
            
            if (!chatApiResponse.IsSuccess) return;

            var response = chatApiResponse.GetResult();

            Console.WriteLine(response?.PrintMembers());
        }
    }
}
```
