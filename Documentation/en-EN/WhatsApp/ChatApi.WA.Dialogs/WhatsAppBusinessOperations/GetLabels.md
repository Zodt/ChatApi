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

using WhatsAppApi.Core.Helpers;
using WhatsAppApi.Core.Connect;
using WhatsAppApi.Core.Connect.Interfaces;

using WhatsAppApi.Dialogs;
using WhatsAppApi.Dialogs.Responses.UI.Interfaces;

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
            IDialogOperations operation = new DialogOperations(connect);

            var userInterfaceOperations = operation.UserInterfaceOperations.Value;
            var whatsAppBusinessOperations = userInterfaceOperations.WhatsAppBusinessOperations.Value;
            var whatsAppResponse = whatsAppBusinessOperations.GetLabels();
            if (!whatsAppResponse.IsSuccess) Console.WriteLine(whatsAppResponse.Exception);
            var actual = whatsAppResponse.GetResult();

            if (actual?.LabelCollection is null) return;
            foreach (var label in actual.LabelCollection)
            {
                Console.WriteLine(label.LabelId);
                Console.WriteLine(label.LabelName);
                Console.WriteLine(label.HexColor);
            }
        }
    }
}
