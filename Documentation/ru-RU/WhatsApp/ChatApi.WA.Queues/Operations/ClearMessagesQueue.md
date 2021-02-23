# Очистить очередь на отправку сообщений.
**<span style="color:green">Замечание по реализации</span>** <br/>
Этот метод нужен когда вы случайно отправили тысячи сообщений подряд. <br/>
Данный метод доступен как в синхронной, так и в асинхронной реализации

## Параметры ответа
|  `Параметр`   | `Описание`                            | `Тип данных параметра`      | 
|:-------------:|:-------------------------------------:|:---------------------------:|
|`Message`|  Статус отчистки очереди сообщений  | `Integer`                   |
|`MessagesCollection` | Содержимое первых ста сообщений из очищенной очереди     | `MessageTextBodyCollection` |

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

            IWhatsAppResponse<IClearMessagesQueueResponse?> response = queuesOperation.ClearMessagesQueue();
            if (response.IsSuccess) throw response.Exception!;

            var messageResponse = response.GetResult();
            Console.WriteLine(messageResponse!.Message);
        }
    }
}
```