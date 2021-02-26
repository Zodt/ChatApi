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
            if (!chatApiResponse.IsSuccess) throw chatApiResponse.Exception!;

            var response = chatApiResponse.GetResult();
            Console.WriteLine(response?.PrintMembers());
        }
    }
}
```