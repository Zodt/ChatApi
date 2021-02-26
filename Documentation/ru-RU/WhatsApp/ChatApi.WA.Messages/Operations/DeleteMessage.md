# Удаление сообщения
**<span style="color:green">Замечание по реализации</span>** Сообщение будет добавлено в очередь на отправку и доставлено даже если телефон отключен от интернета или авторизация не пройдена.<br>
Для отправки нужен только один из двух параметров для определения адресата - chatId или phone.<br/>
Данный метод доступен как в синхронной, так и в асинхронной реализации

## Параметры запроса
| `Параметр` | `Описание`                        | `Тип данных параметра` | `Обязательный параметр` |
|:----------:|:----------------------------------|:----------------------:|:-----------------------:|
|  `MessageId`  | Уникальный идентификатор сообщения, которое необходимо удалить. <br/> Пример: <br/> false_17472822486@c.us_DF38E6A25B42CC8CCE57EC40F | `String` | <ul><li>- [x] </li></ul> |

## Параметры ответа
|  `Параметр`   | `Описание`                        | `Тип данных параметра` | 
|:-------------:|:----------------------------------|:----------------------:|
|     `Id`      | Уникальный идентификатор сообщения<br/>Пример: false_17472822486@c.us_DF38E6A25B42CC8CCE57EC40F | `String` 
|    `Sent`     | Флаг успешности отправки сообщения на сервер | `Boolean`
|   `Message`   | Статус отправки сообщения<br/> | `String` 

## Пример использования
```csharp
using System;

using ChatApi.Core.Connect;
using ChatApi.Core.Connect.Interfaces;

using ChatApi.WA.Messages;

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

            string messageId = "false_17472822486@c.us_DF38E6A25B42CC8CCE57EC40F";
            var chatApiResponse = messageOperation.DeleteMessage(messageId);
            if (!chatApiResponse.IsSuccess) throw chatApiResponse.Exception!;

            var response = chatApiResponse.GetResult();
            Console.WriteLine(response?.PrintMembers());
        }
    }
}
```
