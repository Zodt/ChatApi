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

            IWhatsAppResponse<IClearActionsQueueResponse?> response = queuesOperation.ClearActionsQueue();
            if (response.IsSuccess) throw response.Exception!;

            var messageResponse = response.GetResult();
            Console.WriteLine(messageResponse!.Message);
        }
    }
}
```