# Удаление ярлыка.
**<span style="color:green">Замечание по реализации</span>** <br/>
Функционал доступен только для WhatsApp Business. <br/>
Данный метод доступен как в синхронной, так и в асинхронной реализации.

## Параметры запроса
| `Параметр`        | `Описание`                        | `Тип данных параметра` | `Обязательный параметр`  |
|:-----------------:|:----------------------------------|:----------------------:|:------------------------:|
| `LabelId`         | Уникальный идентификатор ярлыка.  | `String`               | <ul><li>- [x] </li></ul> |

## Параметры ответа
|  `Параметр`       | `Описание`                        | `Тип данных параметра` | 
|:-----------------:|:----------------------------------|:----------------------:|
| `Result`          | Результат создания.               | `String`               |
| `Success`         | Флаг успешного удаления ярлыка.   | `Boolean`              |

## Пример использования
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

            ILabelRemoveRequest request = new LabelRemoveRequest
            {
                LabelId = "LabelId",
            };

            var whatsAppResponse = operation.UserInterfaceOperations.RemoveLabel(request);
            if (!whatsAppResponse.IsSuccess) Console.WriteLine(whatsAppResponse.Exception);
            var actual = whatsAppResponse.GetResult();

            Console.WriteLine(actual?.Success is not null ? actual.Result : actual?.ErrorMessage);
        }
    }
}
