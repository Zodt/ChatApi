# Get the chat list.
**<span style="color:green">Implementation notes</span>** <br/>
The chat list includes avatars. <br/>
This method is available in both synchronous and asynchronous implementations

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

using WhatsAppApi.Core.Helpers;
using WhatsAppApi.Core.Connect;
using WhatsAppApi.Core.Connect.Interfaces;

using WhatsAppApi.Dialogs;
using WhatsAppApi.Dialogs.Interfaces;
using WhatsAppApi.Dialogs.Responses.Interfaces;

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
            IDialogOperations operation = new DialogOperations(Сonnect);
            
            IOperationMessageResult request = new OperationMessageResult
            {
                Phone = "7(999) 111-11-11" // or "79991111111@c.us"
            };
            
            var actionResult = operation.RemoveDialog(request);
            if(!actionResult.IsSuccess) throw actionResult.Exception!;
            
            var actual = actionResult.GetResult();
    
            if (actual?.Result is null) return;
            Console.WriteLine(actual.Result?.Message);
        }
    }
}
```
