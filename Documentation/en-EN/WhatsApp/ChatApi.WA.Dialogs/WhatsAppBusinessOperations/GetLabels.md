# Getting a collection of labels.
**<span style="color:green">Implementation note</span>** <br/>
The functionality is only available for WhatsApp Business. <br/>
This method is available in both synchronous and asynchronous implementations.

## Response
| `Parameter`           | `Description`                                           | `The data type of the parameter` | 
|:---------------------:|:--------------------------------------------------------|:--------------------------------:|
| `LabelCollection`     | A collection of label.                                  | `LabelCollection`                |

## Parameters of the `LabelCollection`
|  `Параметр`       | `Описание`                        | `Тип данных параметра` | 
|:-----------------:|:----------------------------------|:----------------------:|
| `LabelId`         | Unique ID of the label.           | `String`               |
| `HexColor`        | Label Color.                      | `String`               |
| `LabelName`       | Name of the label.                | `String`               |

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
            
            var chatApiResponse = whatsAppBusinessOperations.GetLabels();
            if (!chatApiResponse.IsSuccess) Console.WriteLine(chatApiResponse.Exception);
            var response = chatApiResponse.GetResult();

            Console.WriteLine(response?.PrintMembers());
        }
    }
}
```