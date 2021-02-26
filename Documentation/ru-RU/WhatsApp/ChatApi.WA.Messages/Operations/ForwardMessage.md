# Переотправка сообщения/-ий
**<span style="color:green">Замечание по реализации</span>** Сообщение будет добавлено в очередь на отправку и доставлено даже если телефон отключен от интернета или авторизация не пройдена.<br>
Для отправки нужен только один из двух параметров для определения адресата - chatId или phone.<br/>
Данный метод доступен как в синхронной, так и в асинхронной реализации

## Параметры запроса
| `Параметр` | `Описание`                        | `Тип данных параметра` | `Обязательный параметр` |
|:----------:|:----------------------------------|:----------------------:|:-----------------------:|
|  `Phone`   | Номер телефона, начинающийся с кода страны. <br/> Для России и Казахстана это всегда 7, затем 10 цифр. <br/> Сообщения на номера телефона с 8 не будут доставлены. <br/> Пример: "79995253422". | `String` | <ul><li>- [x] Указан только Phone</li><li>- [ ] Указан только ChatId</li></ul> |
|  `ChatId`  | ID чата из списка сообщений. <br/> Примеры: <br/> 17633123456@c.us для личных сообщений<br/> 17680561234-1479621234@g.us для группы. | `String` | <ul><li>- [x] Указан только ChatId</li><li>- [ ] Указан только Phone</li></ul> |
|  `MessageId`  | Идентификатор сообщения, которое необходимо переслать. <br/> Пример: <br/> false_17472822486@c.us_DF38E6A25B42CC8CCE57EC40F | `ForwardMessagesCollection` | <ul><li>- [ ] </li></ul> |

## Параметры ответа
|  `Параметр`   | `Описание`                        | `Тип данных параметра` | 
|:-------------:|:----------------------------------|:----------------------:|
|     `Id`      | Уникальный идентификатор сообщения <br/> Пример: false_17472822486@c.us_DF38E6A25B42CC8CCE57EC40F | `String` 
|    `Sent`     | Флаг успешности отправки сообщения на сервер | `Boolean`
|   `Message`   | Статус отправки сообщения | `String` 

## Пример использования
```csharp
using System;

using ChatApi.Core.Connect;
using ChatApi.Core.Connect.Interfaces;

using ChatApi.WA.Messages;
using ChatApi.WA.Messages.Collections;

using ChatApi.WA.Messages.Requests;
using ChatApi.WA.Messages.Requests.Interfaces;

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
            IMessagesOperation messageOperation = new MessagesOperation(Connect);

            IForwardMessageRequest request = new ForwardMessageRequest
            {
                Phone = "7(900) 111-11-11",
                MessagesCollection = new ForwardMessagesCollection
                {
                    "false_6590996758@c.us_3EB03104D2B84CEAD82F", 
                    "false_6590996758@c.us_3G0310CEAD824DEB42B8"
                }
            };

            var chatApiResponse = messageOperation.ForwardMessage(request);
            if (!chatApiResponse.IsSuccess) throw chatApiResponse.Exception!;

            var response = chatApiResponse.GetResult();
            Console.WriteLine(response?.PrintMembers());
        }
    }
}
```
