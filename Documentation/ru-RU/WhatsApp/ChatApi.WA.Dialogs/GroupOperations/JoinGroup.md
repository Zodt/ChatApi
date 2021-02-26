# Присоединение к группе, используя пригласительную ссылку или код
**<span style="color:green">Замечание по реализации</span>** <br/>
Данный метод доступен как в синхронной, так и в асинхронной реализации.

## Параметры запроса
| `Параметр` | `Описание`                        | `Тип данных параметра` | `Обязательный параметр` |
|:----------:|:----------------------------------|:----------------------:|:-----------------------:|
| `InvitationCode`  | Код из пригласительной ссылки | `String` | <ul><li>- [x] Указан только InvitationCode</li><li>- [ ] Указан только InvitationLink</li></ul>
| `InvitationLink`  | Пригласительная ссылка из информации о группе. | `String` | <ul><li>- [x] Указан только InvitationLink</li><li>- [ ] Указан только InvitationCode</li></ul>

## Параметры ответа

|  `Параметр`           | `Описание`                                            | `Тип данных параметра` | 
|:---------------------:|:------------------------------------------------------|:----------------------:|
| `ChatId`              | Уникальный идентификатор группы                       | `String`

## Пример использования
```csharp
using System;

using ChatApi.Core.Connect;
using ChatApi.Core.Connect.Interfaces;
using ChatApi.Core.Response.Interfaces;

using ChatApi.WA.Dialogs;
using ChatApi.WA.Dialogs.Helpers.Collections;
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

            IJoinGroupRequest request = new JoinGroupRequest
            {
                InvitationLink = "https://chat.whatsapp.com/GUF2kjFAFZKBRI8vhs2sqK"
            };

            var chatApiResponse = groupOperations.JoinGroup(request);
            if(!chatApiResponse.IsSuccess) throw chatApiResponse.Exception!;
            
            var response = chatApiResponse.GetResult();
            Console.WriteLine(response?.PrintMembers());
        }
    }
}
```



