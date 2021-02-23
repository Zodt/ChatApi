# Get a list of messages sorted by time in descending order.
**<span style="color:green">Implementation notes</span>**<br/>
The message will be added to the queue for sending and delivered even if the phone is disconnected from the Internet or authorization is not passed.<br/>
Only one of two parameters is needed to determine the destination - chatId or phone.<br/>
This method is available in both synchronous and asynchronous implementations

## Request
| `Parameter` | `Description`                        | `The data type of the parameter` | `Required parameter` |
|:-----------:|:-------------------------------------|:--------------------------------:|:--------------------:|
|  `Page`   | Page number, starts from 0, 0 by default. <br/> Example: 5 | `Integer` | <ul><li>- [ ] </li></ul> |
|  `Count`   | Messages count per page, 100 by default. <br/> Example: 200 | `Integer` | <ul><li>- [ ] </li></ul> |
|  `ChatId`   | Filter messages by chatId. <br/> Example: "17472822486-1603286775@g.us" | `String` | <ul><li>- [ ] </li></ul> |

## Response
| `Parameter`           | `Description`                                           | `The data type of the parameter` | 
|:---------------------:|:--------------------------------------------------------|:--------------------------------:|
| `Page`                | Current data page                                       |            `Integer`             |
| `Messages`            | The collection of messages                              |        `MessageCollection`       |

###  Parameters of the `MessageCollection`
| `Parameter`           | `Description`                                           | `The data type of the parameter` | 
|:---------------------:|:--------------------------------------------------------|:--------------------------------:|
| `Id`          | Unique message id <br/> Example: false_17472822486@c.us_DF38E6A25B42CC8CCE57EC40F | `String`
| `Body`        | Text message for type "chat", or link to download the file for "ptt", "image", "audio", "video" and "document", or latitude and longitude for "location", or message "[Call]" for "call_log" | `String`
| `Type`        | Type of the message | `MessageType`
| `Time`        | Sending time | `DateTime`
| `Sent`        | Success flag for sending a message to the server | `Boolean`
| `Self`        | null - a message written from another account | `Integer`
| `Author`      | Author ID of the message, useful for groups | `String`
| `ChatId`      | The unique ID of the chat | `String`
| `FromMe`      | true - outgoing message, false - incoming message | `Boolean`
| `Message`     | Message sending status | `String`
| `ChatName`    | The name of the chat | `String`
| `SenderName`  | The name of the message sender | `String`
| `IsForwarded` | null - not a re-sent message, otherwise the number of re-sent messages | `Integer`
| `MessageNumber`| Serial number of the message in the database | `String`
| `QuotedMessageId` | Unique identifier of the quoted message | `String`
| `QuotedMessageBody` | Text of the quoted message | `String`
| `QuotedMessageType` | Type of the quoted message | `MessageType`

## Example
```csharp
using System;

using WhatsAppApi.Connect;
using WhatsAppApi.Core.Helpers;

using WhatsAppApi.Core.Connect;
using WhatsAppApi.Core.Connect.Interfaces;

using WhatsAppApi.Messages.Requests;
using WhatsAppApi.Messages.Responses.Interfaces;

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
            IMessagesOperation operation = new MessagesOperation(Сonnect);
            
            IMessagesRequest request = new MessagesRequest
            {
                ChatId = "17472822486-1603286775@g.us"
            };
            
            var actionResult = operation.GetMessagesHistory(request);
            if(!actionResult.IsSuccess) throw actionResult.Exception!;
            
            var actual = actionResult.GetResult();
            
            foreach (var message in Actual.Messages) 
                Console.WriteLine(message.Body);

        }
    }
}
```
