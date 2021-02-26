# Mark dialog as "pinned"
**<span style="color:green">Implementation note</span>** <br/>
It does not work if the account has already assigned 3 dialogs, but the status "success" will be returned to the Result property <br/>
This method is available in both synchronous and asynchronous implementations.

## Request
| `Parameter` | `Description`                        | `The data type of the parameter` |   `Required parameter`   |
|:-----------:|:-------------------------------------|:--------------------------------:|:------------------------:|
|  `Phone`   | A phone number starting with the country code. <br/> Messages to phone numbers from 8 will not be delivered. <br/> USA example: 17472822486. | `String` | <ul><li>- [x] Only Phone is specified</li><li>- [ ] Only ChatId is specified</li></ul> |
|  `ChatId`  | Chat ID from the message list. <br/> Examples: <br/> 17633123456@c.us for private messages<br/> 17680561234-1479621234@g.us for the group. | `String`   | <ul><li>- [x] Only ChatId is specified</li><li>- [ ] Only Phone is specified</li></ul> |

## Response
| `Parameter`           | `Description`                                           | `The data type of the parameter` | 
|:---------------------:|:--------------------------------------------------------|:--------------------------------:|
| `ChatId`              | Unique ID of the dialog.                                | `String`                         |
| `Result`              | The status of the request.                              | `String`                         |

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
            IDialogOperations operation = new DialogOperations(Connect);
            IUserInterfaceOperations userInterfaceOperations = operation.UserInterfaceOperations.Value;
            
            IPinChatRequest request = new PinChatRequest
            {
                Phone = "+7(999) 111-11-11"// or ChatId = "79991111111@c.us"
            };

            var chatApiResponse = userInterfaceOperations.PinChat(request);
            if (!chatApiResponse.IsSuccess) throw chatApiResponse.Exception!;
            var response = chatApiResponse.GetResult();

            Console.WriteLine(response?.PrintMembers());
        }
    }
}
```