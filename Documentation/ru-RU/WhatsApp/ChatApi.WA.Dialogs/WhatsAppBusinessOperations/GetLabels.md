# Получение коллекции ярлыков
**<span style="color:green">Замечание по реализации</span>** <br/>
Функционал доступен только для WhatsApp Business. <br/>
Данный метод доступен как в синхронной, так и в асинхронной реализации.

## Параметры ответа
|  `Параметр`       | `Описание`                        | `Тип данных параметра` | 
|:-----------------:|:----------------------------------|:----------------------:|
| `LabelCollection` | Коллекция ярлыков.                | `LabelCollection`      |

## Параметры объекта `LabelCollection`
|  `Параметр`       | `Описание`                        | `Тип данных параметра` | 
|:-----------------:|:----------------------------------|:----------------------:|
| `LabelId`         | Уникальный идентификатор ярлыка.  | `String`               |
| `HexColor`        | Цвет ярлыка.                      | `String`               |
| `LabelName`       | Наименование ярлыка.              | `String`               |

## Пример использования
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
