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
            
            ILabelRemoveRequest request = new LabelRemoveRequest
            {
                LabelId = "LabelId",
            };

            var chatApiResponse = whatsAppBusinessOperations.RemoveLabel(request);
            if (!chatApiResponse.IsSuccess) Console.WriteLine(chatApiResponse.Exception);
            var response = chatApiResponse.GetResult();

            Console.WriteLine(response?.PrintMembers());
        }
    }
}
```