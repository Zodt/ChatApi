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
            
            IDialogCollectionRequest request = new DialogCollectionRequest
            {
                Limit = 1
            };
            
            var actionResult = operation.GetDialogs(request);
            if(!actionResult.IsSuccess) throw actionResult.Exception!;
            
            var actual = actionResult.GetResult();
    
            if (actual?.Dialogs is null) return;
            foreach (var dialog in actual.Dialogs)
            {
                Console.WriteLine(dialog.ChatId);
                Console.WriteLine(dialog.ChatName);
                Console.WriteLine(dialog.ChatCreator);
                Console.WriteLine(dialog.ChatCreationDate);
                Console.WriteLine(dialog.LastMessageTime);
                Console.WriteLine(dialog.Image);
                Console.WriteLine(dialog.AdditionalChatInfo?.IsGroup);
                Console.WriteLine(dialog.AdditionalChatInfo?.GroupInviteLink);

                Console.WriteLine("\n'Participants'");
                if (dialog?.AdditionalChatInfo is not {Participants: not null}) return;
                foreach (string participant in dialog.AdditionalChatInfo?.Participants!) Console.WriteLine(participant);
            }
        }
    }
}
```
