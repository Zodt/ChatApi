# Sending an audio message
**<span style="color:green">Implementation notes</span>**<br/> The message will be added to the queue for sending and delivered even if the phone is disconnected from the Internet or authorization is not passed.<br/>
Only one of two parameters is needed to determine the destination - chatId or phone.<br/>
This method is available in both synchronous and asynchronous implementations

## Request
| `Parameter` | `Description`                        | `The data type of the parameter` | `Required parameter` |
|:-----------:|:-------------------------------------|:--------------------------------:|:--------------------:|
|  `Audio`   | A link to an audio ogg-file in opus codec <br/> Or base64 ogg-file in opus codec. <br/> Пример: "data:audio/ogg;base64,..."  | `String` | <ul><li>- [x] </li></ul> |
|  `Phone`   | Phone number starting with the country code. <br/> USA example: 17472822486. | `String` | <ul><li>- [x] Only Phone is specified</li><li>- [ ] Only ChatId is specified</li></ul> |
|  `ChatId`  | Chat ID from the message list. <br/> Example: <br/> 17633123456@c.us for private messages and <br/> 17680561234-1479621234@g.us for the group.                                                            | `String` | <ul><li>- [x] Only ChatId is specified</li><li>- [ ] Only Phone is specified</li></ul> |
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
            var sendVoiceRequest = new VoiceMessageRequest
            {
                Phone = "79001111111",
                Audio = "https://s136.convertio.me/p/ZjzVQbYQ1GnkZE4zWrTxEg/3580b0b96441389cdb6a640615131cff/Snoop_Dogg_feat_The_Doors_-_Riders_on_the_storm_Fredwreck_Remix_393298.opus",
            };
        
            IWhatsAppResponse<IMessageResponse?> response = messageOperation.SendVoiceMessage(sendVoiceRequest);
            if (response.IsSuccess) throw response.Exception!;

            var messageResponse = response.GetResult();
            Console.WriteLine(messageResponse!.Message);
        }
    }
}
```