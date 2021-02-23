# Getting a list of messages
**<span style="color:green">Implementation notes</span>**<br/>
The message will be added to the queue for sending and delivered even if the phone is disconnected from the Internet or authorization is not passed.<br/>
Only one of two parameters is needed to determine the destination - chatId or phone.<br/>
This method is available in both synchronous and asynchronous implementations

To receive only new messages, pass the lastMessageNumber parameter from the last query.<br/>
Files from messages are guaranteed to be stored only for 30 days and can be deleted. Download the files as soon as you get to your server.

## Request
| `Parameter` | `Description`                        | `The data type of the parameter` | `Required parameter` |
|:-----------:|:-------------------------------------|:--------------------------------:|:--------------------:|
|  `Last`  | Displays the last 100 messages. If this parameter is passed, then lastMessageNumber is ignored. | `Boolean` | <ul><li>- [ ] </li></ul> |
|  `Limit`  | Sets length of the message list. Default 100. <br/> With value 0 returns all messages. | `Integer` | <ul><li>- [ ] </li></ul> |
|  `ChatId`  | Chat ID from the message list. <br/> Examples: <br/> 17633123456@c.us for private messages and <br/> 17680561234-1479621234@g.us for the group. | `String` | <ul><li>- [ ] </li></ul> |
|  `MinTime`  | Filter messages received after specified time. | `DateTime` | <ul><li>- [ ] </li></ul> |
|  `MaxTime`  | Filter messages received before specified time. | `DateTime` | <ul><li>- [ ] </li></ul> |
|  `LastMessageNumber`  | The lastMessageNumber parameter from the last response. | `Integer` | <ul><li>- [ ] </li></ul> |


## Response
| `Parameter`           | `Description`                                           | `The data type of the parameter` | 
|:---------------------:|:--------------------------------------------------------|:--------------------------------:|
|  `Messages`           | The collection of messages                              |        `MessageCollection`       |      
|  `LastMessageNumber`  | The number of the last required message in the database |             `String`             |

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
                Last = true,
                ChatId = "17472822486-1603286775@g.us",
                MinTime = new DateTime(2021, 02, 04, 16, 42, 47),
                MaxTime = new DateTime(2021, 02, 04, 16, 43, 52),
                Limit = 1
            };
            
            var actionResult = operation.GetMessages(request);
            if(!actionResult.IsSuccess) throw actionResult.Exception!;
            
            var actual = actionResult.GetResult();
            
            foreach (var message in Actual.Messages) 
                Console.WriteLine(message.Body);

        }
    }
}
```
