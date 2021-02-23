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

using WhatsAppApi.Core.Helpers;
using WhatsAppApi.Core.Connect;
using WhatsAppApi.Core.Connect.Interfaces;

using WhatsAppApi.Dialogs;
using WhatsAppApi.Dialogs.Interfaces;
using WhatsAppApi.Dialogs.Responses.Interfaces;

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
            
            IDialogOperations operation = new DialogOperations(connect);

            IJoinGroupRequest request = new JoinGroupRequest
            {
                InvitationLink = "https://chat.whatsapp.com/GUF2kjFAFZKBRI8vhs2sqK"
            };

            var actionResult = operation.GroupOperations.JoinGroup(request);
            if (!whatsAppResponse.IsSuccess) Console.WriteLine(whatsAppResponse.Exception);
            var actual = actionResult.GetResult();

            Console.WriteLine(actual?.ChatId ?? actual?.ErrorMessage);
        }
    }
}
```



