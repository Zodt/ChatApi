# Get outbound messages queue.
**<span style="color:green">Implementation notes</span>** <br/>
When sending messages, all messages are in the queue. If the message is not sent, then it remains in the queue and in time it will be sent again. <br/>
The message may not be sent due to the status of the device connected to the account. <br/>
This method give the last 100 messages in the queue. <br/>
This method is available in both synchronous and asynchronous implementations

## Response
| `Parameter`       | `Description`                           | `The data type of the parameter` | 
|:-----------------:|:----------------------------------------|:--------------------------------:|
|`TotalMessage`     |  Total number of messages in the queue  | `Integer`                   |
|`OutboundMessages` | The collection of messages in the queue | `OutboundMessageCollection` |

## Response of the `OutboundMessages`
| `Parameter` | `Description`                             | `The data type of the parameter` | 
|:-----------:|:-----------------------------------------:|:--------------------------------:|
|`Id`         |  Message id                               | `String`                         |
|`Body`       |  Message content                          | `String`                         |
|`Type`       |  Type of the message                      | `String`                         |
|`LastTimeTrySend` | Last try time to send a message      | `DataTime`                       |
|`MessageAdditionalInformation` | Additional message data | `OutboundMessageCollection`      |

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

            var chatApiResponse = queuesOperation.ShowMessagesQueue();
            if (chatApiResponse.IsSuccess) throw chatApiResponse.Exception!;

            var response = chatApiResponse.GetResult();
            Console.WriteLine(response?.PrintMembers());
        }
    }
}
```