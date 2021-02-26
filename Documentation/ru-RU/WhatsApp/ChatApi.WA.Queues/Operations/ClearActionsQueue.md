# Очистить очередь на выполнение действий.
**<span style="color:green">Замечание по реализации</span>** <br/>
Этот метод нужен когда вы случайно отправили тысячи действий подряд. <br/>
Данный метод доступен как в синхронной, так и в асинхронной реализации

## Параметры ответа
|  `Параметр`   | `Описание`                            | `Тип данных параметра`      | 
|:-------------:|:-------------------------------------:|:---------------------------:|
|`Message`      |  Статус отчистки очереди действий     | `Integer`                   |
|`ActionsCollection` | Содержимое первых ста действий из очищенной очереди     | `ActionOperationsCollection` |

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

            var chatApiResponse = queuesOperation.ClearActionsQueue();
            if (chatApiResponse.IsSuccess) throw chatApiResponse.Exception!;

            var response = chatApiResponse.GetResult();
            Console.WriteLine(response?.PrintMembers());
        }
    }
}
```