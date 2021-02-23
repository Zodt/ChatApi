# Создание ярлыка.
**<span style="color:green">Замечание по реализации</span>** <br/>
Функционал доступен только для WhatsApp Business. <br/>
Данный метод доступен как в синхронной, так и в асинхронной реализации.

## Параметры запроса
| `Параметр`        | `Описание`                        | `Тип данных параметра` | `Обязательный параметр`  |
|:-----------------:|:----------------------------------|:----------------------:|:------------------------:|
| `Name`            | Наименование ярлыка.              | `String`               | <ul><li>- [x] </li></ul> |

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
