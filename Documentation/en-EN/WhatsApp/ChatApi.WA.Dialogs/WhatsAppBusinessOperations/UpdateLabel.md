# Changing the shortcut settings.
**<span style="color:green">Implementation note</span>** <br/>
The functionality is only available for WhatsApp Business. <br/>
This method is available in both synchronous and asynchronous implementations.

## Request
| `Parameter` | `Description`                        | `The data type of the parameter` |   `Required parameter`   |
|:-----------:|:-------------------------------------|:--------------------------------:|:------------------------:|
| `LabelId`   | Unique ID of the label.              | `String`                         | <ul><li>- [x] </li></ul> |
| `HexColor`  | Label Color.                         | `String`                         | <ul><li>- [x] Only HexColor is specified</li><li>- [ ] Only LabelName is specified</li></ul>
| `LabelName` | Name of the label.                   | `String`                         | <ul><li>- [x] Only LabelName is specified</li><li>- [ ] Only HexColor is specified</li></ul>

## Response
| `Parameter`           | `Description`                                           | `The data type of the parameter` | 
|:---------------------:|:--------------------------------------------------------|:--------------------------------:|
| `Result`              | The result of the creation.                             | `String`                         |
| `LabelInfo`           | Data for the created label.                             | `Label`                          |

## Parameters of the `Label`
| `Parameter`           | `Description`                                           | `The data type of the parameter` | 
|:---------------------:|:--------------------------------------------------------|:--------------------------------:|
| `LabelId`             | Unique ID of the label.                                 | `String`                         |
| `HexColor`            | Label Color.                                            | `String`                         |
| `LabelName`           | Name of the label.                                      | `String`                         |

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

            ILabelUpdateRequest request = new LabelUpdateRequest
            {
                LabelId = "labelId",
                LabelName = "VIP Client"
            };

            var chatApiResponse = whatsAppBusinessOperations.UpdateLabel(request);
            if (!chatApiResponse.IsSuccess) Console.WriteLine(chatApiResponse.Exception);
            var response = chatApiResponse.GetResult();

            Console.WriteLine(response?.PrintMembers());
        }
    }
}
```