# Получение информации о диалоге.
**<span style="color:green">Замечание по реализации</span>** <br/> 
Позволяет получить актуальную информацию о чате, даже если он отсутствует в списке чатов аккаунта. <br/> 
После выполнения запроса информация доступна в списке чатов.<br/>
Данный метод доступен как в синхронной, так и в асинхронной реализации.

## Параметры запроса
| `Параметр` | `Описание`                        | `Тип данных параметра` | `Обязательный параметр` |
|:----------:|:----------------------------------|:----------------------:|:-----------------------:|
|  `ChatId`  | Фильтровать сообщения по chatId <br/> Примеры: <br/> 17633123456@c.us для личных сообщений и <br/> 17680561234-1479621234@g.us для группы. | `String` | <ul><li>- [x] </li></ul> |


## Параметры ответа

|  `Параметр`           | `Описание`                                            | `Тип данных параметра` | 
|:---------------------:|:------------------------------------------------------|:----------------------:|
| `Image`               | HTTPS ссылка на аватар или изображение группы         | `String`
| `ChatId`              | Уникальный идентификатор чата                         | `String`
| `ChatName`            | Наименование чата                                     | `String`
| `ChatCreator`         | Создатель чата                                        | `String`
| `LastMessageTime`     | Дата последнего сообщения в чате                      | `DateTime`
| `ChatCreationDate`    | Дата создания чата                                    | `DateTime`
| `AdditionalChatInfo`  | Дополнительная информация о чате                      | `AdditionalChatInfo`

###  Параметры объекта `AdditionalChatInfo`

|  `Параметр`   | `Описание`                        | `Тип данных параметра`  | 
|:-------------:|:----------------------------------|:-----------------------:|
| `IsGroup`| Флаг, определяющий выгружена была информация по группе или по чату | `Boolean`|
| `Participants`| Участники диалога                 | `ParticipantsCollection`|
| `GroupInviteLink`| Ссылка на приглашение в группу | `String`|


## Пример использования
```csharp
using System;

using ChatApi.Core.Connect;
using ChatApi.Core.Connect.Interfaces;
using ChatApi.Core.Response.Interfaces;

using ChatApi.WA.Dialogs;
using ChatApi.WA.Dialogs.Requests;
using ChatApi.WA.Dialogs.Responses.Interfaces;

using ChatApiClient.Properties;
namespace ChatApiClient
{
    internal class Program
    {
        public static IWhatsAppConnect Connect { get; set; }

        private static void Main()
        {
            // put your chat-api's data
            Connect = new WhatsAppConnect(WhatsApp_Server, WhatsApp_Instance, WhatsApp_Token); 
            IDialogOperations dialogOperations = new DialogOperations(Connect);

            var dialogRequest = new DialogRequest
            {
                ChatId = "17472822486-1603286775@g.us"
            };

            var chatApiResponse = dialogOperations.GetDialog(dialogRequest);
            if (!chatApiResponse.IsSuccess) throw chatApiResponse.Exception!;

            var response = chatApiResponse.GetResult();
            Console.WriteLine(response?.PrintMembers());
        }
    }
}
```
