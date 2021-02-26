# Remove the label from the dialog.
**<span style="color:green">Implementation note</span>** <br/>
This method is available in both synchronous and asynchronous implementations.

## Request
| `Parameter` | `Description`                        | `The data type of the parameter` | `Required parameter` |
|:-----------:|:-------------------------------------|:--------------------------------:|:--------------------:|
|  `LabelId` | ID of the label | `String` | <ul><li>- [x] </li></ul> |
|  `Phone`   | A phone number starting with the country code. <br/> Messages to phone numbers from 8 will not be delivered. <br/> USA example: 17472822486. | `String` | <ul><li>- [x] Only Phone is specified</li><li>- [ ] Only ChatId is specified</li></ul> |
|  `ChatId`  | Chat ID from the message list. <br/> Examples: <br/> 17633123456@c.us for private messages<br/> 17680561234-1479621234@g.us for the group. | `String`   | <ul><li>- [x] Only ChatId is specified</li><li>- [ ] Only Phone is specified</li></ul> |

## Response
| `Parameter`   | `Description`              | `The data type of the parameter` | 
|:-------------:|:---------------------------|:--------------------------------:|
| `Result`      | The result of the query.   | `String`                         |
| `ChatId`      | The unique ID of the chat. | `String`                         |

## Example
```csharp
using System;

using ChatApi.Core.Connect;
using ChatApi.Core.Connect.Interfaces;

using ChatApi.WA.Dialogs;
using ChatApi.WA.Dialogs.Operations.Interfaces;

using ChatApi.WA.Dialogs.Requests.UI;
using ChatApi.WA.Dialogs.Requests.UI.Interfaces;

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
            IDialogOperations dialogOperations = new DialogOperations(Connect);
            IUserInterfaceOperations userInterfaceOperations = dialogOperations.UserInterfaceOperations.Value;
            IWhatsAppBusinessOperations whatsAppBusinessOperations = userInterfaceOperations.WhatsAppBusinessOperations.Value;

            IUnlabeledChatRequest request = new UnlabeledChatRequest()
            {
                LabelId = "",
                ChatId = "79991111111-1111111111@g.us"
            };

            var chatApiResponse = whatsAppBusinessOperations.UnlabeledChat(request);
            if (!chatApiResponse.IsSuccess) Console.WriteLine(chatApiResponse.Exception);
            var response = chatApiResponse.GetResult();

            Console.WriteLine(response?.PrintMembers());
        }
    }
}
```