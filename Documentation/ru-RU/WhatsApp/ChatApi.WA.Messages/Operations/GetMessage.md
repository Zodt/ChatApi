# Получение списка сообщений
**<span style="color:green">Замечание по реализации</span>** Сообщение будет добавлено в очередь на отправку и доставлено даже если телефон отключен от интернета или авторизация не пройдена.<br>
Для отправки нужен только один из двух параметров для определения адресата - chatId или phone.<br/>
Данный метод доступен как в синхронной, так и в асинхронной реализации

## Параметры запроса
| `Параметр` | `Описание`                        | `Тип данных параметра` | `Обязательный параметр` |
|:----------:|:----------------------------------|:----------------------:|:-----------------------:|
|  `Last`  | Отображает последние 100 сообщений. <br/> Если передан этот параметр, то `LastMessageNumber` игнорируется. | `String` | <ul><li>- [ ] </li></ul> |
|  `Limit`  | Устанавливает длину списка сообщений. По умолчанию 100. <br/> При значении 0 вернет все сообщения. | `String` | <ul><li>- [ ] </li></ul> |
|  `ChatId`  | Фильтровать сообщения по chatId <br/> Примеры: <br/> 17633123456@c.us для личных сообщений и <br/> 17680561234-1479621234@g.us для группы. | `String` | <ul><li>- [ ] </li></ul> |
|  `MinTime`  | Фильтрует сообщения, полученные после указанного времени. | `String` | <ul><li>- [ ] </li></ul> |
|  `MaxTime`  | Фильтрует сообщения, полученные до указанного времени. | `String` | <ul><li>- [ ] </li></ul> |
|  `LastMessageNumber`  | Параметр lastMessageNumber из предыдущего запроса. | `String` | <ul><li>- [ ] </li></ul> |

## Параметры ответа
|  `Параметр`           | `Описание`                                            | `Тип данных параметра` | 
|:---------------------:|:------------------------------------------------------|:----------------------:|
|  `Messages`           | Коллекция сообщений                                   |   `MessageCollection`
|  `LastMessageNumber`  | Номер последнего необходимого сообщения в базе данных |        `String`

###  Параметры объекта `MessageCollection`
|  `Параметр`   | `Описание`                        | `Тип данных параметра` | 
|:-------------:|:----------------------------------|:----------------------:|
| `Id`          | Уникальный идентификатор сообщения<br/>Пример: false_17472822486@c.us_DF38E6A25B42CC8CCE57EC40F | `String` 
| `Body`        | Текстовое сообщение типа "chat", или ссылка, для скачки файла у сообщений типа "ptt", <br/> "image", "audio", "video" и "document", или широта и долгота для "location", <br/> или сообщение "[Call]" у "call_log" | `String` 
| `Type`        | Тип сообщения | `MessageType` 
| `Time`        | Время отправки | `DateTime`
| `Sent`        | Флаг успешности отправки сообщения на сервер | `Boolean`
| `Self`        | null - сообщение написанное с другого аккаунта | `Integer`
| `Author`      | Уникальный идентификатор автора сообщения, полезный для групп | `String` 
| `ChatId`      | Уникальный идентификатор чата | `String` 
| `FromMe`      | true - исходящее сообщение, false - входящее | `Boolean`
| `Message`     | Статус отправки сообщения | `String` 
| `ChatName`    | Наименование чата | `String` 
| `SenderName`  | Имя отправителя | `String`
| `IsForwarded` | null - не переотправленное сообщение, иначе количество переотправлений сообщения, | `Integer`
| `MessageNumber`| Порядковый номер сообщения в базе данных | `String`
| `QuotedMessageId` | Уникальный идентификатор цитированного сообщения | `String`
| `QuotedMessageBody` | Текст цитированного сообщения | `String`
| `QuotedMessageType` | Тип цитированного сообщения | `MessageType`

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
            
            IMessagesRequest request = new MessagesRequest
            {
                Last = true,
                ChatId = "17472843486-1603286775@g.us",
                MinTime = new DateTime(2021, 02, 04, 16, 42, 47),
                MaxTime = new DateTime(2021, 02, 04, 16, 43, 52),
                Limit = 1
            };
            
            var chatApiResponse = messageOperation.GetMessages(request);
            if (!chatApiResponse.IsSuccess) throw chatApiResponse.Exception!;

            var response = chatApiResponse.GetResult();
            Console.WriteLine(response?.PrintMembers());
        }
    }
}
```
