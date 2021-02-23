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

using System;

using WhatsAppApi.Core.Connect;
using WhatsAppApi.Core.Connect.Interfaces;
using WhatsAppApi.Core.Helpers;

using WhatsAppApi.Queues;
using WhatsAppApi.Queues.Interfaces;
using WhatsAppApi.Queues.Responses.Interfaces;

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

            var queuesOperation = new QueuesOperation(Connect);

            IWhatsAppResponse<IShowActionsQueueResponse?> response = queuesOperation.ShowActionsQueue();
            if (response.IsSuccess) throw response.Exception!;

            var messageResponse = response.GetResult();
            Console.WriteLine(messageResponse!.TotalMessage);
        }
    }
}
```