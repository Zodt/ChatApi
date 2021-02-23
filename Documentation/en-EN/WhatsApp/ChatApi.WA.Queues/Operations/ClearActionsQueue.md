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