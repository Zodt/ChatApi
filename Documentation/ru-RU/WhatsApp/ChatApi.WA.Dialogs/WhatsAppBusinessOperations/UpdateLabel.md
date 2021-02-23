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
