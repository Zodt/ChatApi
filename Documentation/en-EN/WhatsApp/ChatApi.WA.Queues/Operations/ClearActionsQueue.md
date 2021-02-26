# Clear outbound actions queue.
**<span style="color:green">Implementation notes</span>** <br/>
This method is needed when you accidentally sent thousands of messages in a row. <br/>
This method is available in both synchronous and asynchronous implementations

## Response
| `Parameter` | `Description`                        | `The data type of the parameter` | 
|:-----------:|:-------------------------------------|:--------------------------------:|
|`Message`|  Actions queue clear status              | `Integer`                        |
|`ActionsCollection` | Type of the first hundred actions from the cleaned queue | `ActionOperationsCollection` |

## Example
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