# Получить список сообщений, которые стоят в очереди на отправку, но еще не отправлены.
**<span style="color:green">Замечание по реализации</span>** <br/> 
При отправке сообщений, все сообщения попадают в очередь. Если сообщение не отправлено, то оно остается в очереди и через время снова будет отправлено. <br/> 
Сообщение может быть не отправлено из-за статуса подключенного к аккаунту устройства. <br/> 
Этот метод выводит 100 последних сообщений в очереди. <br/>
Данный метод доступен как в синхронной, так и в асинхронной реализации


## Параметры ответа
|  `Параметр`   | `Описание`                            | `Тип данных параметра`      | 
|:-------------:|:-------------------------------------:|:---------------------------:|
|`TotalMessage`|  Общее количество сообщений в очереди  | `Integer`                   |
|`OutboundMessages` | Коллекция сообщений в очереди     | `OutboundMessageCollection` |

## Параметры объекта `OutboundMessageCollection`
|  `Параметр`   | `Описание`                            | `Тип данных параметра`      | 
|:-------------:|:-------------------------------------:|:---------------------------:|
|`Id`|  Идентификационный номер сообщения в очереди     | `String`                   |
|`Body`|  Тело сообщения                                | `String`                   |
|`Type`|  Тип сообщения                                 | `String`                   |
|`LastTimeTrySend` | Время последней попытки отправить сообщение     | `DataTime` |
|`MessageAdditionalInformation` | Дополнительная информация о сообщении     | `OutboundMessageCollection` |


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

            var chatApiResponse = queuesOperation.ShowMessagesQueue();
            if (chatApiResponse.IsSuccess) throw chatApiResponse.Exception!;

            var response = chatApiResponse.GetResult();
            Console.WriteLine(response?.PrintMembers());
        }
    }
}
```