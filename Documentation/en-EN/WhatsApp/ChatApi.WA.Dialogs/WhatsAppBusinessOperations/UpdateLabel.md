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

using WhatsAppApi.Core.Connect;
using WhatsAppApi.Core.Connect.Interfaces;

using WhatsAppApi.Dialogs;
using WhatsAppApi.Dialogs.Interfaces;

using WhatsAppApi.Dialogs.SubOperations.UI.Responses.Interfaces;

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
            IDialogOperations operations = new DialogOperations(Сonnect);

            ILabelUpdateRequest request = new LabelUpdateRequest
            {
                LabelId = "labelId",
                LabelName = "VIP Client"
            };

            whatsAppResponse = operation.UserInterfaceOperations.UpdateLabel(request);
            if (!whatsAppResponse.IsSuccess) Console.WriteLine(whatsAppResponse.Exception);
            actual = whatsAppResponse.GetResult();

            Console.WriteLine(actual?.Success is not null ? actual.Result : actual?.ErrorMessage);
        }
    }
}
