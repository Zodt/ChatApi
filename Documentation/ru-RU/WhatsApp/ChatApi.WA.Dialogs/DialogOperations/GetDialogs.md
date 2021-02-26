# Получение списка чатов.
**<span style="color:green">Замечание по реализации</span>** <br/>
Список чатов включает в себя аватары. <br/>
Данный метод доступен как в синхронной, так и в асинхронной реализации.

## Параметры запроса
| `Параметр` | `Описание`                        | `Тип данных параметра` | `Обязательный параметр` |
|:----------:|:----------------------------------|:----------------------:|:-----------------------:|
|  `Limit`  | Устанавливает длину списка диалогов. По умолчанию 0. <br/> При значении 0 вернет все диалоги. | `Integer` | <ul><li>- [ ] </li></ul> |
|  `Page`   | Номер страницы, начиная с 0. По умолчанию - 0. <br/> Пример: 5 | `Integer` | <ul><li>- [ ] </li></ul> |

## Параметры ответа

|  `Параметр`           | `Описание`                                            | `Тип данных параметра` | 
|:---------------------:|:------------------------------------------------------|:----------------------:|
| `Dialogs`             | Список диалогов                                       | `DialogCollection`     |

###  Параметры объекта `DialogCollection`

|  `Параметр`           | `Описание`                                            | `Тип данных параметра` | 
|:---------------------:|:------------------------------------------------------|:----------------------:|
| `Image`               | HTTPS ссылка на аватар или изображение группы         | `String`               |
| `ChatId`              | Уникальный идентификатор чата                         | `String`               |
| `ChatName`            | Наименование чата                                     | `String`               |
| `ChatCreator`         | Создатель чата                                        | `String`               |
| `LastMessageTime`     | Дата последнего сообщения в чате                      | `DateTime`             |
| `ChatCreationDate`    | Дата создания чата                                    | `DateTime`             |
| `AdditionalChatInfo`  | Дополнительная информация о чате                      | `AdditionalChatInfo`   |

###  Параметры объекта `AdditionalChatInfo`

|  `Параметр`      | `Описание`                                                         | `Тип данных параметра`  | 
|:----------------:|:-------------------------------------------------------------------|:-----------------------:|
| `IsGroup`        | Флаг, определяющий выгружена была информация по группе или по чату | `Boolean`               |
| `Participants`   | Участники диалога                                                  | `ParticipantsCollection`|
| `GroupInviteLink`| Ссылка на приглашение в группу                                     | `String`                |

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
        internal static IWhatsAppConnect Connect { get; set; }

        internal static void Main()
        {
            // put your chat-api's data
            Connect = new WhatsAppConnect(WhatsApp_Server, WhatsApp_Instance, WhatsApp_Token); 
            IDialogOperations operation = new DialogOperations(Сonnect);
            
            var request = new DialogCollectionRequest
            {
                Limit = 1
            };
            
            IChatApiResponse<IDialogCollectionResponse?> chatApiResponse = dialogOperations.GetDialogs(request);
            if(!chatApiResponse.IsSuccess) throw chatApiResponse.Exception!;
            
            var response = chatApiResponse.GetResult();
            Console.WriteLine(response?.PrintMembers());
        }
    }
}
```
