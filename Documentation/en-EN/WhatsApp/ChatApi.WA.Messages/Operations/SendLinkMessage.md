# Send a link
**<span style="color:green">Implementation notes</span>**<br/> The message will be added to the queue for sending and delivered even if the phone is disconnected from the Internet or authorization is not passed.<br/>
Only one of two parameters is needed to determine the destination - chatId or phone.<br/>
This method is available in both synchronous and asynchronous implementations

## Request
| `Parameter` | `Description`                        | `The data type of the parameter` | `Required parameter` |
|:-----------:|:-------------------------------------|:--------------------------------:|:--------------------:|
|  `Body`    | HTTP or HTTPS link. <br/>Example: "https://wikimedia.org"| `String` | <ul><li>- [x] </li></ul> |
|  `Text`    | Text containing the link. | `String` | <ul><li>- [ ] </li></ul> |
|  `Title`   | Title for send link. | `String` | <ul><li>- [x] </li></ul> |
|  `Phone`   | A phone number starting with the country code. You do not need to add your number. <br/> USA example: 17472822486.                              | `String` | <ul><li>- [x] Only Phone is specified</li><li>- [ ] Only ChatId is specified</li></ul> |
|  `ChatId`  | Chat ID from the message list. <br/> Examples: <br/> 17633123456@c.us for private messages and <br/> 17680561234-1479621234@g.us for the group. | `String` | <ul><li>- [x] Only ChatId is specified</li><li>- [ ] Only Phone is specified</li></ul> |
|  `Description`  | Description for send link. | `String` | <ul><li>- [ ] </li></ul> |
|  `previewBase64`| Base64-encoded file with mime data. <br/> Example: <br/> "data:image/jpeg;base64,/9j/4AAQSkZJRgAbAQ..." | `String` | <ul><li>- [x] </li></ul> |
|  `MentionedPhones`  | Phone numbers of the mentioned contacts in an array or in a comma-separated string. <br/> Example: <br/> ["78005553535","78005553536"] | `MentionedPhonesCollection` | <ul><li>- [ ] </li></ul> |
|  `QuotedMessageId`  | Quoted message ID from the message list. <br/> Example: <br/> false_17472822486@c.us_DF38E6A25B42CC8CCE57EC40F | `String` | <ul><li>- [ ] </li></ul> |

## Response
|  `Parameter`   | `Description`                                                                     | `The data type of the parameter` | 
|:--------------:|:----------------------------------------------------------------------------------|:--------------------------------:|
|      `Id`      | Unique message id <br/> Example: false_17472822486@c.us_DF38E6A25B42CC8CCE57EC40F |             `String`
|     `Sent`     | Success flag for sending a message to the server                                  |             `Boolean`
|    `Message`   | Posting status message                                                            |             `String`

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
            
            ILinkMessageRequest request = new LinkMessageRequest
            {
                Phone = "79001111111",
                Title = "TestFile",
                Body = "https://upload.wikimedia.org/wikipedia/ru/3/33/NatureCover2001.jpg",
                PreviewBase64 = "data:image/jpeg;base64,/9j/4AAQSkZJRgABAQ..."
            };
        
            var chatApiResponse = messageOperation.SendLinkMessage(request);
            if (!chatApiResponse.IsSuccess) throw chatApiResponse.Exception!;

            var response = chatApiResponse.GetResult();
            Console.WriteLine(response?.PrintMembers());
        }
    }
}
```