# Получить список действий, которые стоят в очереди на отправку, но еще не отправлены.
**<span style="color:green">Замечание по реализации</span>** <br/>
При создании действия, все действия попадают в очередь. Если действие не выполнено, то оно остается в очереди, и, через определённое сервером время, снова будет осуществлена попытка выполнить действие. <br/> 
Сообщение может быть не отправлено из-за статуса подключенного к аккаунту устройства. <br/>
Этот метод выводит 100 последних действий в очереди. <br/>
Данный метод доступен как в синхронной, так и в асинхронной реализации


## Параметры ответа
|  `Параметр`      | `Описание`                            | `Тип данных параметра`      | 
|:----------------:|:-------------------------------------:|:---------------------------:|
|`TotalActions`    | Общее количество действий в очереди   | `Integer`                   |
|`OutboundActions` | Коллекция действий в очереди          | `OutboundActionCollection`  |

## Параметры объекта `OutboundMessageCollection`
|  `Параметр`   | `Описание`                                           | `Тип данных параметра`      | 
|:-------------:|:----------------------------------------------------:|:---------------------------:|
|`Id`|  Идентификационный номер действия в очереди                     | `String`                    |
|`Type`|  Тип действия                                                 | `String`                    |
|`LastTimeTrySend` | Время последней попытки отправить действие        | `DataTime`                  |
|`MessageAdditionalInformation` | Дополнительная информация о действии | `String`                    |

## Пример использования
```csharp
using System;

using ChatApi.Core.Connect;
using ChatApi.Core.Connect.Interfaces;

using ChatApi.WA.Queues;

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
            IQueueOperations queuesOperation = new QueueOperations(Connect);

            var chatApiResponse = queuesOperation.ShowActionsQueue();
            if (chatApiResponse.IsSuccess) throw chatApiResponse.Exception!;

            var response = chatApiResponse.GetResult();
            Console.WriteLine(response?.PrintMembers());
        }
    }
}
```