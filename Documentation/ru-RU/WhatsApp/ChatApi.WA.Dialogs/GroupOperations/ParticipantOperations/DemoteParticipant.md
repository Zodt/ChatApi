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

using ChatApi.Core.Connect;
using ChatApi.Core.Connect.Interfaces;
using ChatApi.Core.Response.Interfaces;

using ChatApi.WA.Dialogs;
using ChatApi.WA.Dialogs.Operations.Interfaces;

using ChatApi.WA.Dialogs.Requests;
using ChatApi.WA.Dialogs.Requests.Interfaces;
using ChatApi.WA.Dialogs.Responses.Interfaces;

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
            IDialogOperations operation = new DialogOperations(Connect);
            IGroupOperations groupOperations = operation.GroupOperations.Value;
            IGroupParticipantOperations participantOperations = groupOperations.GroupParticipantOperations.Value;
            
            IDemoteGroupParticipantRequest request = new DemoteGroupParticipantRequest
            {
                ParticipantPhone = "+7(999) 111-11-11"// or ParticipantChatId = "79991111111@c.us"
            };

            var chatApiResponse = participantOperations.DemoteParticipant(request);
            if (!chatApiResponse.IsSuccess) throw chatApiResponse.Exception!;

            var response = chatApiResponse.GetResult();
            Console.WriteLine(response?.PrintMembers());
        }
    }
}
```