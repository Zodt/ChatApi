# Лишение участника прав администрирования группы.
**<span style="color:green">Замечание по реализации</span>** <br/>
Данный метод доступен как в синхронной, так и в асинхронной реализации.

## Параметры запроса
| `Параметр` | `Описание`                        | `Тип данных параметра` | `Обязательный параметр` |
|:----------:|:----------------------------------|:----------------------:|:-----------------------:|
| `GroupId`  | Уникальный идентификатор группы | `String` | <ul><li>- [ ] </li></ul>
| `ParticipantPhone`  | Номер телефона добавляемого участника в группу | `String` | <ul><li>- [x] Указан только ParticipantPhone</li><li>- [ ] Указан только ParticipantChatId</li></ul>
| `ParticipantChatId` | Уникальный идентификатор добавляемого участника в группу | `String` | <ul><li>- [x] Указан только ParticipantChatId</li><li>- [ ] Указан только ParticipantPhone</li></ul>

## Параметры ответа

|  `Параметр`           | `Описание`                                            | `Тип данных параметра` | 
|:---------------------:|:------------------------------------------------------|:----------------------:|
| `GroupId`             | Уникальный идентификатор группы                       | `String`
| `IsSuccess`           | Флаг успешности добавления участника в группу         | `Boolean`
| `StatusMessage`       | Статус успешности добавления участника в группу       | `String`

## Пример использования
```csharp
using System;

using WhatsAppApi.Core.Helpers;
using WhatsAppApi.Core.Connect;
using WhatsAppApi.Core.Connect.Interfaces;

using WhatsAppApi.Dialogs;
using WhatsAppApi.Dialogs.Interfaces;
using WhatsAppApi.Dialogs.SubOperations.Group.Requests;
using WhatsAppApi.Dialogs.SubOperations.Group.Requests.Interfaces;
using WhatsAppApi.Dialogs.SubOperations.Group.Responses.Interfaces;

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
            IDialogOperations operation = new DialogOperations(Сonnect);
            
            IDemoteGroupParticipantRequest request = new DemoteGroupParticipantRequest
            {
                ParticipantPhone = "+7(999) 111-11-11"// or ParticipantChatId = "79991111111@c.us"
            };

            var whatsAppResponse = operation.GroupOperations.DemoteParticipant(request);
            if (!whatsAppResponse.IsSuccess) Console.WriteLine(whatsAppResponse.Exception);
            var actual = whatsAppResponse.GetResult();

            Console.WriteLine(actual?.StatusMessage ?? actual?.ErrorMessage);
        }
    }
}
```