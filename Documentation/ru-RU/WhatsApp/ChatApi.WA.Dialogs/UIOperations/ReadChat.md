# Отправление статуса "Прочитано" в диалог.
**<span style="color:green">Замечание по реализации</span>** <br/>
Данный метод доступен как в синхронной, так и в асинхронной реализации.

## Параметры запроса
| `Параметр`        | `Описание`                        | `Тип данных параметра` | `Обязательный параметр`  |
|:-----------------:|:----------------------------------|:----------------------:|:------------------------:|
|  `Phone`   | Номер телефона, начинающийся с кода страны. <br/> Для России и Казахстана это всегда 7, затем 10 цифр. <br/> Сообщения на номера телефона с 8 не будут доставлены. <br/> Пример: "79995253422". | `String` | <ul><li>- [x] Указан только Phone</li><li>- [ ] Указан только ChatId</li></ul> |
|  `ChatId`  | ID чата из списка сообщений. <br/> Примеры: <br/> 17633123456@c.us для личных сообщений<br/> 17680561234-1479621234@g.us для группы. | `String` | <ul><li>- [x] Указан только ChatId</li><li>- [ ] Указан только Phone</li></ul> |

## Параметры ответа
|  `Параметр`  | `Описание`                          | `Тип данных параметра` | 
|:------------:|:------------------------------------|:----------------------:|
| `Read`       | Флаг успешности запроса.            | `Boolean`              |
| `ChatId`     | Уникальный идентификатор сообщений. | `String`               |
| `Message`    | Статус прочтения диалога.           | `String`               |

## Пример использования
```csharp
using System;

using WhatsAppApi.Core.Helpers;
using WhatsAppApi.Core.Connect;
using WhatsAppApi.Core.Connect.Interfaces;

using WhatsAppApi.Dialogs;
using WhatsAppApi.Dialogs.Interfaces;
using WhatsAppApi.Dialogs.SubOperations.UI.Requests;
using WhatsAppApi.Dialogs.SubOperations.UI.Requests.Interfaces;
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

            IReadChatRequest request = new ReadChatRequest
            {
                Phone = "+7(999) 111-11-11"// or ChatId = "79991111111@c.us"
            };

            var whatsAppResponse = operation.UserInterfaceOperations.ReadChat(request);
            if (!whatsAppResponse.IsSuccess) Console.WriteLine(whatsAppResponse.Exception);
            var actual = whatsAppResponse.GetResult();

            Console.WriteLine(actual?.Read ?? actual?.ErrorMessage);
        }
    }
}
