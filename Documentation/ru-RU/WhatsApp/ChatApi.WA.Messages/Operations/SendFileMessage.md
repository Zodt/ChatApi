# Отправка файла
**<span style="color:green">Замечание по реализации</span>** Сообщение будет добавлено в очередь на отправку и доставлено даже если телефон отключен от интернета или авторизация не пройдена.<br>
Для отправки нужен только один из двух параметров для определения адресата - chatId или phone.<br/>
Данный метод доступен как в синхронной, так и в асинхронной реализации

## Параметры запроса
| `Параметр` | `Описание`                        | `Тип данных параметра` | `Обязательный параметр` |
|:----------:|:----------------------------------|:----------------------:|:-----------------------:|
|  `Body`    | Ссылка на файл. <br/>Пример: "https://pbs.twimg.com/media/DC3uMPnXkAA0fK9.jpg" или <br/> файл в base64 "data:image/jpeg;base64,/9j/4AAQSkZJRgABAQ..."| `String` | <ul><li>- [x] </li></ul> |
|  `Phone`   | Номер телефона, начинающийся с кода страны. <br/> Для России и Казахстана это всегда 7, затем 10 цифр. <br/> Сообщения на номера телефона с 8 не будут доставлены. <br/> Пример: "79995253422". | `String` | <ul><li>- [x] Указан только Phone</li><li>- [ ] Указан только ChatId</li></ul> |
|  `ChatId`  | ID чата из списка сообщений. <br/> Примеры: <br/> 17633123456@c.us для личных сообщений<br/> 17680561234-1479621234@g.us для группы. | `String` | <ul><li>- [x] Указан только ChatId</li><li>- [ ] Указан только Phone</li></ul> |
|  `Cached`  | Текст под файлом. <br/> Пример: "Изображение для @78005553535". | `String` | <ul><li>- [ ] </li></ul> |
|  `Caption` | Попытаться отправить загруженный ранее файл вместо загрузки при каждом запросе. | `String` | <ul><li>- [ ] </li></ul> |
|  `Filename`| Имя отправляемого файла. <br/> Примеры: <br/> "hello.xlsx" | `String` | <ul><li>- [x] </li></ul> |
|  `MentionedPhones`  | Телефонные номера упомянутых контактов в массиве. <br/> Примеры: <br/> ["78005553535","78005553536"] | `MentionedPhonesCollection` | <ul><li>- [ ] </li></ul> |
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
            
            IFileMessageRequest request = new FileMessageRequest
            {
                Phone = "79001111111",
                FileName = "TestFile",
                Body = "https://upload.wikimedia.org/wikipedia/ru/3/33/NatureCover2001.jpg"
            };
        
            var chatApiResponse = messageOperation.SendFileMessage(request);
            if (!chatApiResponse.IsSuccess) throw chatApiResponse.Exception!;

            var response = chatApiResponse.GetResult();
            Console.WriteLine(response?.PrintMembers());
        }
    }
}
```