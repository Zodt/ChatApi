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

            var chatApiResponse = queuesOperation.ClearMessagesQueue();
            if (!chatApiResponse.IsSuccess) throw chatApiResponse.Exception!;

            var response = chatApiResponse.GetResult();
            Console.WriteLine(response?.PrintMembers());
        }
    }
}
```