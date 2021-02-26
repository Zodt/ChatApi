# Leave group.
**<span style="color:green">Implementation note</span>** <br/>
This method is available in both synchronous and asynchronous implementations.

## Request
| `Parameter` | `Description`                        | `The data type of the parameter` | `Required parameter` |
|:-----------:|:-------------------------------------|:--------------------------------:|:--------------------:|
|  `Phone`   | A phone number starting with the country code. <br/> Messages to phone numbers from 8 will not be delivered. <br/> USA example: 17472822486. | `String` | <ul><li>- [x] Only Phone is specified</li><li>- [ ] Only ChatId is specified</li></ul> |
|  `ChatId`  | Chat ID from the message list. <br/> Examples: <br/> 17633123456@c.us for private messages<br/> 17680561234-1479621234@g.us for the group. | `String`   | <ul><li>- [x] Only ChatId is specified</li><li>- [ ] Only Phone is specified</li></ul> |

## Response
| `Parameter`   | `Description`           | `The data type of the parameter` | 
|:-------------:|:------------------------|:--------------------------------:|
| `Result`      | The result of the query |`OperationMessageResult`          |

###  Parameters of the `OperationMessageResult`
| `Parameter`   | `Description`           | `The data type of the parameter` | 
|:-------------:|:------------------------|:--------------------------------:|
| `Message`     | The result of the query | `String`                         |

## Example
```csharp
using System;

using ChatApi.Core.Connect;
using ChatApi.Core.Connect.Interfaces;
using ChatApi.Core.Response.Interfaces;

using ChatApi.WA.Dialogs;
using ChatApi.WA.Dialogs.Helpers.Collections;
using ChatApi.WA.Dialogs.Operations.Interfaces;

using ChatApi.WA.Dialogs.Requests;
using ChatApi.WA.Dialogs.Requests.Interfaces;
using ChatApi.WA.Dialogs.Responses.Interfaces;

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
            IDialogOperations operation = new DialogOperations(Connect);
            IGroupOperations groupOperations = operation.GroupOperations.Value;
            
            ILeaveGroupRequest request = new LeaveGroupRequest
            {
                ChatId = "79269014589-1613397458@g.us"
            };

            var chatApiResponse = groupOperations.LeaveGroup(request);
            if(!chatApiResponse.IsSuccess) throw chatApiResponse.Exception!;
            
            var response = chatApiResponse.GetResult();
            Console.WriteLine(response?.PrintMembers());
        }
    }
}
```