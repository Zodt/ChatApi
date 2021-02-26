# Отправка адреса
**<span style="color:green">Замечание по реализации</span>** Сообщение будет добавлено в очередь на отправку и доставлено даже если телефон отключен от интернета или авторизация не пройдена.<br>
Для отправки нужен только один из двух параметров для определения адресата - chatId или phone.<br/>
Данный метод доступен как в синхронной, так и в асинхронной реализации

## Параметры запроса
| `Параметр` | `Описание`                        | `Тип данных параметра` | `Обязательный параметр` |
|:----------:|:----------------------------------|:----------------------:|:-----------------------:|
|  `Phone`   | Номер телефона, начинающийся с кода страны. <br/> Для России и Казахстана это всегда 7, затем 10 цифр. <br/> Сообщения на номера телефона с 8 не будут доставлены. <br/> Пример: "79995253422". | `String` | <ul><li>- [x] Указан только Phone</li><li>- [ ] Указан только ChatId</li></ul> |
|  `ChatId`  | ID чата из списка сообщений. <br/> Примеры: <br/> 17633123456@c.us для личных сообщений<br/> 17680561234-1479621234@g.us для группы. | `String` | <ul><li>- [x] Указан только ChatId</li><li>- [ ] Указан только Phone</li></ul> |
|  `Address`    | Текст под сообщением с локацией. <br/> Поддерживает две строки. <br/> Чтобы использовать две строки, используйте символ "\n".| `String` | <ul><li>- [x] </li></ul> |
|  `Latitude` | Широта. | `Double` | <ul><li>- [x] </li></ul> |
|  `Longitude`  | Долгота. | `Double` | <ul><li>- [x] </li></ul> |

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
            
            ILocationMessageRequest request = new LocationMessageRequest
            {
                Phone = "+7(985) 462-44-18",
                Address = @"Text under the message with the location.\nSupports two strings.",
                Longitude = 55.1179,
                Latitude = 36.6021
            };
            
            var chatApiResponse = messageOperation.SendLocationMessage(request);
            if (!chatApiResponse.IsSuccess) throw chatApiResponse.Exception!;

            var response = chatApiResponse.GetResult();
            Console.WriteLine(response?.PrintMembers());
        }
    }
}
```