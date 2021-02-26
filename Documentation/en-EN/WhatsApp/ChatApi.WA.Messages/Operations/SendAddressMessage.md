# Sending an address
**<span style="color:green">Implementation notes</span>**<br/> The message will be added to the queue for sending and delivered even if the phone is disconnected from the Internet or authorization is not passed.<br/>
Only one of two parameters is needed to determine the destination - chatId or phone.<br/>
This method is available in both synchronous and asynchronous implementations

## Request
| `Parameter` | `Description`                        | `The data type of the parameter` | `Required parameter` |
|:-----------:|:-------------------------------------|:--------------------------------:|:--------------------:|
|  `Phone`   | A phone number starting with the country code. You do not need to add your number. <br/> USA example: 17472822486.                              | `String` | <ul><li>- [x] Only Phone is specified</li><li>- [ ] Only ChatId is specified</li></ul> |
|  `ChatId`  | Chat ID from the message list. <br/> Examples: <br/> 17633123456@c.us for private messages and <br/> 17680561234-1479621234@g.us for the group. | `String` | <ul><li>- [x] Only ChatId is specified</li><li>- [ ] Only Phone is specified</li></ul> |
|  `Address` | Text under the location. <br/> Supports two lines. <br/> To use two lines, use the "\n" symbol.| `String` | <ul><li>- [x] </li></ul> |
|  `Latitude` | Latitude. | `Double` | <ul><li>- [x] </li></ul> |
|  `Longitude`  | Longitude. | `Double` | <ul><li>- [x] </li></ul> |

## Response
| `Parameter` | `Description`                        | `The data type of the parameter` | 
|:-----------:|:-------------------------------------|:--------------------------------:|
|     `Id`      | Unique message id <br/> Example: false_17472822486@c.us_DF38E6A25B42CC8CCE57EC40F | `String`
|    `Sent`     | Success flag for sending a message to the server | `Boolean`
|   `Message`   | Posting status message | `String`

## Example
```csharp
using System;

using ChatApi.Core.Connect;
using ChatApi.Core.Connect.Interfaces;

using ChatApi.WA.Messages;
using ChatApi.WA.Messages.Collections;

using ChatApi.WA.Messages.Requests;
using ChatApi.WA.Messages.Requests.Interfaces;

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
            
            ILocationMessageRequest request = new LocationMessageRequest
            {
                Phone = "+7(985) 462-44-18",
                Address = @"Text under the message with the location.\nSupports two strings.",
                Longitude = 55.1179,
                Latitude = 36.6021
            };
            
            var chatApiResponse = messageOperation.SendLocationMessage(request);
            if (!chatApiResponse.IsSuccess) throw chatApiResponse.Exception!;

            var response = chatApiResponse.GetResult();
            Console.WriteLine(response?.PrintMembers());
        }
    }
}
```