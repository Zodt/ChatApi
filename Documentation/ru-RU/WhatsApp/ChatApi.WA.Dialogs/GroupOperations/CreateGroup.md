# Создание группы.
**<span style="color:green">Замечание по реализации</span>** <br/>
Если хост iPhone, то наличие всех в списке контактов обязательно. <br/>
Группа будет добавлена в очередь на отправку и рано или поздно создана, даже если телефон отключен от интернета или авторизация не пройдена. <br/>
Обновление от 2 октября 2018: В ответе параметр ChatId будет заполнен, если удалось создать группу на вашем телефоне в течение 20 секунд. <br/>
Данный метод доступен как в синхронной, так и в асинхронной реализации.

## Параметры запроса
| `Параметр` | `Описание`                        | `Тип данных параметра` | `Обязательный параметр` |
|:----------:|:----------------------------------|:----------------------:|:-----------------------:|
| `Avatar`   | Аватар группы 640x640px. Файл в Base64 | `String` | <ul><li>- [ ] </li></ul>
| `Phones`   | Список номеров телефонов участников создаваемой группы | `PhonesCollection` | <ul><li>- [x] Указан только Phones</li><li>- [ ] Указан только ChatIds</li></ul>
| `ChatIds`  | Список уникальных идентификаторов участников создаваемой группы | `ChatIdsCollection` | <ul><li>- [x] Указан только ChatIds</li><li>- [ ] Указан только Phones</li></ul>
| `Preview`  | Превью для группы 96x96px. Файл в Base64 | `String` | <ul><li>- [ ] </li></ul>
| `GroupName`| Наименование группы               | `String`               | <ul><li>- [x] </li></ul>
| `MessageText` | Текст сообщения, которое будет отправлено в группу после ее создания. <br/> Если не указывать этот параметр, сообщение отправлено не будет. | `String` | <ul><li>- [ ] </li></ul>

## Параметры ответа

|  `Параметр`           | `Описание`                                            | `Тип данных параметра` | 
|:---------------------:|:------------------------------------------------------|:----------------------:|
| `Created`             | Флаг создания группы                                  | `Boolean`
| `Message`             | Статус создания группы                                | `String`
| `ChatId`              | Уникальный идентификатор созданной группы             | `String`
| `GroupInviteLink`     | Ссылка на приглашение в группу                        | `String`

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
       
            ICreateGroupRequest request = new CreateGroupRequest 
            {
                Phones = new PhonesCollection { "7(999) 111-11-11" }, // or ChatIds = new ChatIdsCollection{ "79991111111@c.us" },
                GroupName = "TestBotGroup",
                MessageText = "Test group was created",
            };
            
            IChatApiResponse<ICreateGroupResponse?> chatApiResponse = groupOperations.CreateGroup(request);
            if(!chatApiResponse.IsSuccess) throw chatApiResponse.Exception!;
            
            var response = chatApiResponse.GetResult();
            Console.WriteLine(response?.PrintMembers());
        }
    }
}
```



