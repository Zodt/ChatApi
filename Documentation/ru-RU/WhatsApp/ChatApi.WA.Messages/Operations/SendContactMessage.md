# Отправка контакта
**<span style="color:green">Замечание по реализации</span>** Сообщение будет добавлено в очередь на отправку и доставлено даже если телефон отключен от интернета или авторизация не пройдена.<br>
Для отправки нужен только один из двух параметров для определения адресата - chatId или phone.<br/>
Данный метод доступен как в синхронной, так и в асинхронной реализации

## Параметры запроса
| `Параметр` | `Описание`                        | `Тип данных параметра` | `Обязательный параметр` |
|:----------:|:----------------------------------|:----------------------:|:-----------------------:|
|  `Phone`   | Номер телефона, начинающийся с кода страны. <br/> Для России и Казахстана это всегда 7, затем 10 цифр. <br/> Сообщения на номера телефона с 8 не будут доставлены. <br/> Пример: "79995253422". | `String` | <ul><li>- [x] Указан только Phone</li><li>- [ ] Указан только ChatId</li></ul> |
|  `ChatId`  | ID чата из списка сообщений. <br/> Примеры: <br/> 17633123456@c.us для личных сообщений<br/> 17680561234-1479621234@g.us для группы. | `String` | <ul><li>- [x] Указан только ChatId</li><li>- [ ] Указан только Phone</li></ul> |
|  `ContactId`   | Массив ID контактов.  | `ContactCollection` | <ul><li>- [x] </li></ul> |
|  `QuotedMessageId`  | Идентификатор цитируемого сообщения из списка сообщений. <br/> Примеры: <br/> false_17472822486@c.us_DF38E6A25B42CC8CCE57EC40F | `String` | <ul><li>- [ ] </li></ul> |

## Параметры ответа
|  `Параметр`   | `Описание`                        | `Тип данных параметра` | 
|:-------------:|:----------------------------------|:----------------------:|
|     `Id`      | Уникальный идентификатор сообщения<br/>Пример: false_17472822486@c.us_DF38E6A25B42CC8CCE57EC40F | `String`
|    `Sent`     | Флаг успешности отправки сообщения на сервер | `Boolean`
|   `Message`   | Статус отправки сообщения<br/> | `String`

## Пример использования
```csharp
using System;

using WhatsAppApi.Connect;
using WhatsAppApi.Core.Helpers;

using WhatsAppApi.Core.Connect;
using WhatsAppApi.Core.Connect.Interfaces;

using WhatsAppApi.Messages.Requests;
using WhatsAppApi.Messages.Responses.Interfaces;

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

            var messageOperation = new MessagesOperation(Connect);
            var sendContactRequest = new ContactMessageRequest
            {
                Phone = "79001111111",
                PreviewBase64 = "data:image/jpeg;base64,/9j/4AAQSkZJRgABAQ...",
                ContactId = new ContactCollection { "79001111111", "79001111111@c.us" },
                Body = "https://upload.wikimedia.org/wikipedia/ru/3/33/NatureCover2001.jpg"
            };
        
            IWhatsAppResponse<IMessageResponse?> response = messageOperation.SendContactMessage(sendContactRequest);
            if (response.IsSuccess) throw response.Exception!;

            var messageResponse = response.GetResult();
            Console.WriteLine(messageResponse!.Message);
        }
    }
}
```