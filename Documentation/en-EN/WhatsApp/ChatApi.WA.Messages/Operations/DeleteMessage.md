# Deleting a message
**<span style="color:green">Implementation notes</span>**<br/> The message will be added to the queue for sending and delivered even if the phone is disconnected from the Internet or authorization is not passed.<br/>
Only one of two parameters is needed to determine the destination - chatId or phone.<br/>
This method is available in both synchronous and asynchronous implementations

## Request
| `Parameter` | `Description`                        | `The data type of the parameter` | `Required parameter` |
|:-----------:|:-------------------------------------|:--------------------------------:|:--------------------:|
| `MessageId` | The unique identifier of the message that you want to delete . <br/> Example: <br/> false_17472822486@c.us_DF38E6A25B42CC8CCE57EC40F | `String` | <ul><li>- [x] </li></ul> |

## Response
| `Parameter` | `Description`                        | `The data type of the parameter` | 
|:-----------:|:-------------------------------------|:--------------------------------:|
|     `Id`      | Unique message id <br/> Example: false_17472822486@c.us_DF38E6A25B42CC8CCE57EC40F | `String`
|    `Sent`     | Flag for sending a message to the server | `Boolean`
|   `Message`   | Posting status message | `String`

## Example
```csharp
using System;

using ChatApi.Core.Connect;
using ChatApi.Core.Connect.Interfaces;

using ChatApi.WA.Messages;

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
            IMessagesOperation messageOperation = new MessagesOperation(Connect);

            string messageId = "false_17472822486@c.us_DF38E6A25B42CC8CCE57EC40F";
            var chatApiResponse = messageOperation.DeleteMessage(messageId);
            if (!chatApiResponse.IsSuccess) throw chatApiResponse.Exception!;

            var response = chatApiResponse.GetResult();
            Console.WriteLine(response?.PrintMembers());
        }
    }
}
```
