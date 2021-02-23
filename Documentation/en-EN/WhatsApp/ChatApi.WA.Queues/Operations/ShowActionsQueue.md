# Clear outbound actions queue.
**<span style="color:green">Implementation notes</span>** <br/>
When you create an action, all actions are queued up. If an action is not executed, it remains in the queue and will be sent for execution in time again. <br/>
The action cannot be executed due to the status of the device connected to the account. <br/>
This method give the last 100 actions in the queue. <br/>
This method is available in both synchronous and asynchronous implementations

## Response
| `Parameter` | `Description`                               | `The data type of the parameter` | 
|:-----------:|:--------------------------------------------|:--------------------------------:|
|`TotalActions`    | Total number of actions in the queue   | `Integer`                        |
|`OutboundActions` | The collection of actions in the queue | `OutboundActionCollection`       |

## Response of the `OutboundActions`
| `Parameter` | `Description`                                          | `The data type of the parameter` | 
|:-----------:|:------------------------------------------------------:|:--------------------------------:|
|`Id`         | Action id in queue                                     | `String`                         |
|`Type`       | Type of the action in queue                            | `String`                         |
|`LastTimeTrySend` | Last try time to execute a action                 | `DataTime`                       |
|`MessageAdditionalInformation` | Additional action data               | `String`                         |

## Example
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