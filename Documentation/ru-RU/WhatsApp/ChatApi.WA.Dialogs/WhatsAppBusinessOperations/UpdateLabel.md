# Изменение параметров ярлыка.
**<span style="color:green">Замечание по реализации</span>** <br/>
Функционал доступен только для WhatsApp Business. <br/>
Данный метод доступен как в синхронной, так и в асинхронной реализации.

## Параметры запроса
| `Параметр`        | `Описание`                        | `Тип данных параметра` | `Обязательный параметр`  |
|:-----------------:|:----------------------------------|:----------------------:|:------------------------:|
| `LabelId`         | Уникальный идентификатор ярлыка.  | `String`               | <ul><li>- [x] </li></ul> |
| `HexColor`        | Цвет ярлыка.                      | `String`               | <ul><li>- [x] Указан только HexColor</li><li>- [ ] Указан только LabelName</li></ul>
| `LabelName`       | Наименование ярлыка.              | `String`               | <ul><li>- [x] Указан только LabelName</li><li>- [ ] Указан только HexColor</li></ul>

## Параметры ответа
|  `Параметр`       | `Описание`                        | `Тип данных параметра` | 
|:-----------------:|:----------------------------------|:----------------------:|
| `Result`          | Результат создания.               | `String`               |
| `LabelInfo`       | Данные по созданному ярлыку.      | `Label`                |

## Параметры объекта `Label`
|  `Параметр`       | `Описание`                        | `Тип данных параметра` | 
|:-----------------:|:----------------------------------|:----------------------:|
| `LabelId`         | Уникальный идентификатор ярлыка.  | `String`               |
| `HexColor`        | Цвет ярлыка.                      | `String`               |
| `LabelName`       | Наименование ярлыка.              | `String`               |

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