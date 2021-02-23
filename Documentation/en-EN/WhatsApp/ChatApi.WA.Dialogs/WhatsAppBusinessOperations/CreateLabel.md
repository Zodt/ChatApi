# Creating a label.
**<span style="color:green">Implementation note</span>** <br/>
The functionality is only available for WhatsApp Business. <br/>
This method is available in both synchronous and asynchronous implementations.

## Request
| `Parameter` | `Description`                        | `The data type of the parameter` |   `Required parameter`   |
|:-----------:|:-------------------------------------|:--------------------------------:|:------------------------:|
| `Name`      | Name of the label.                   | `String`                         | <ul><li>- [x] </li></ul> |

## Response
| `Parameter`           | `Description`                                           | `The data type of the parameter` | 
|:---------------------:|:--------------------------------------------------------|:--------------------------------:|
| `Result`              | The result of the creation.                             | `String`                         |
| `LabelInfo`           | Data for the created label.                             | `Label`                          |

## Parameters of the `Label`
|  `Параметр`       | `Описание`                        | `Тип данных параметра` | 
|:-----------------:|:----------------------------------|:----------------------:|
| `LabelId`         | Unique ID of the label.           | `String`               |
| `HexColor`        | Label Color.                      | `String`               |
| `LabelName`       | Name of the label.                | `String`               |

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

            ILabelCreateRequest request = new LabelCreateRequest()
            {
                Name = "VIP client"
            };

            var whatsAppResponse = operation.UserInterfaceOperations.CreateLabel(request);
            if (!whatsAppResponse.IsSuccess) Console.WriteLine(whatsAppResponse.Exception);
            var actual = whatsAppResponse.GetResult();

            Console.WriteLine(actual?.ErrorMessage);
            if (actual?.Success is null) return;

            Console.WriteLine(actual.Label?.LabelId);
            Console.WriteLine(actual.Label?.LabelName);
            Console.WriteLine(actual.Label?.HexColor);
        }
    }
}
