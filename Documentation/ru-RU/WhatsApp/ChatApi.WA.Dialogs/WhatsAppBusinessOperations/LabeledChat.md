# Присвоение ярлыка диалогу
**<span style="color:green">Замечание по реализации</span>** <br/>
Функционал доступен только для WhatsApp Business. <br/>
Данный метод доступен как в синхронной, так и в асинхронной реализации.

## Параметры запроса
| `Параметр` | `Описание`                        | `Тип данных параметра` | `Обязательный параметр` |
|:----------:|:----------------------------------|:----------------------:|:-----------------------:|
|  `LabelId` | Идентификатор ярлыка. | `String` | <ul><li>- [x] </li></ul> |
|  `Phone`   | Номер телефона, начинающийся с кода страны. <br/> Для России и Казахстана это всегда 7, затем 10 цифр. <br/> Сообщения на номера телефона с 8 не будут доставлены. <br/> Пример: "79995253422". | `String` | <ul><li>- [x] Указан только Phone</li><li>- [ ] Указан только ChatId</li></ul> |
|  `ChatId`  | ID чата из списка сообщений. <br/> Примеры: <br/> 17633123456@c.us для личных сообщений<br/> 17680561234-1479621234@g.us для группы. | `String` | <ul><li>- [x] Указан только ChatId</li><li>- [ ] Указан только Phone</li></ul> |

## Параметры ответа
|  `Параметр`   | `Описание`                        | `Тип данных параметра` | 
|:-------------:|:----------------------------------|:----------------------:|
| `Result`      | Результат запроса.                | `String`               |
| `ChatId`      | Уникальный идентификатор чата.    | `String`               |

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
            
            ILabeledChatRequest request = new LabeledChatRequest
            {
                LabelId = "labelId",
                ChatId = "79991111111-1111111111@g.us"
            };

            var chatApiResponse = whatsAppBusinessOperations.LabeledChat(request);
            if (!chatApiResponse.IsSuccess) Console.WriteLine(chatApiResponse.Exception);
            var response = chatApiResponse.GetResult();

            Console.WriteLine(response?.PrintMembers());
        }
    }
}
```