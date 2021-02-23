# Sending a contact or contact list to a new or existing chat.
**<span style="color:green">Implementation notes</span>**<br/> The message will be added to the queue for sending and delivered even if the phone is disconnected from the Internet or authorization is not passed.<br/>
Only one of two parameters is needed to determine the destination - chatId or phone.<br/>
This method is available in both synchronous and asynchronous implementations

## Request
| `Parameter` | `Description`                        | `The data type of the parameter` | `Required parameter` |
|:-----------:|:-------------------------------------|:--------------------------------:|:--------------------:|
|  `Phone`   | A phone number starting with the country code. You do not need to add your number. <br/> USA example: 17472822486.                              | `String` | <ul><li>- [x] Only Phone is specified</li><li>- [ ] Only ChatId is specified</li></ul> |
|  `ChatId`  | Chat ID from the message list. <br/> Examples: <br/> 17633123456@c.us for private messages and <br/> 17680561234-1479621234@g.us for the group. | `String` | <ul><li>- [x] Only ChatId is specified</li><li>- [ ] Only Phone is specified</li></ul> |
|  `ContactId`   | Contact IDs collection.  | `ContactCollection` | <ul><li>- [x] </li></ul> |
|  `QuotedMessageId`  | Quoted message ID from the message list. <br/> Example: <br/> false_17472822486@c.us_DF38E6A25B42CC8CCE57EC40F | `String` | <ul><li>- [ ] </li></ul> |

## Response
| `Parameter` | `Description`                        | `The data type of the parameter` | 
|:-----------:|:-------------------------------------|:--------------------------------:|
|     `Id`      | Unique message id <br/> Example: false_17472822486@c.us_DF38E6A25B42CC8CCE57EC40F | `String`
|    `Sent`     | Success flag for sending a message to the server | `Boolean`
|   `Message`   | Posting status message | `String`

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

            var messageOperation = new MessagesOperation(Connect);
            var sendContactRequest = new ContactMessageRequest
            {
                Phone = "79001111111",
                PreviewBase64 = "data:image/jpeg;base64,/9j/4AAQSkZJRgABAQ...",
                ContactId = new ContactCollection { "79001111111", "79001111111@c.us" },
                Body = "https://upload.wikimedia.org/wikipedia/ru/3/33/NatureCover2001.jpg"
            };
        
            IWhatsAppResponse<IMessageResponse?> response = messageOperation.SendContactMessage(sendContactRequest);
            if (response.IsSuccess) throw response.Exception!;

            var messageResponse = response.GetResult();
            Console.WriteLine(messageResponse!.Message);
        }
    }
}
```