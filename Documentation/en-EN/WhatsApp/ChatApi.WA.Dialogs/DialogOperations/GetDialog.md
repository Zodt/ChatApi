# Get info about a dialog.
**<span style="color:green">Implementation notes</span>** <br/>
Allow get actual chat info even it not present in dialogs list. <br/>
After executing the request, the data is available in dialogs list.<br/>
This method is available in both synchronous and asynchronous implementations

## Request
| `Parameter` | `Description`                        | `The data type of the parameter` | `Required parameter` |
|:-----------:|:-------------------------------------|:--------------------------------:|:--------------------:|
|  `ChatId`  | Filter messages by chatId <br/> Примеры: <br/> 17633123456@c.us for private messages and <br/> 17680561234-1479621234@g.us for the group. | `String` | <ul><li>- [x] </li></ul> |


## Response
| `Parameter`           | `Description`                                           | `The data type of the parameter` | 
|:---------------------:|:--------------------------------------------------------|:--------------------------------:|
| `Image`               | HTTPS link on avatar or group image         | `String`
| `ChatId`              | The unique ID of the chat                         | `String`
| `ChatName`            | The name of the chat                                     | `String`
| `ChatCreator`         | The Creator of the chat                                        | `String`
| `LastMessageTime`     | Date of last message in chat                      | `DateTime`
| `ChatCreationDate`    | Date the chat was created                                    | `DateTime`
| `AdditionalChatInfo`  | Additional info about chat                      | `AdditionalChatInfo`

###  Parameters of the `AdditionalChatInfo`
| `Parameter`           | `Description`                                           | `The data type of the parameter` | 
|:---------------------:|:--------------------------------------------------------|:--------------------------------:|
| `IsGroup`| Flag indicating whether information was uploaded by group or by chat | `Boolean`|
| `Participants`| Participants of the dialogue                 | `ParticipantsCollection`|
| `GroupInviteLink`| Link to the invitation to the group | `String`|

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
            
            IDialogRequest request = new DialogRequest
            {
                ChatId = "17472822486-1603286775@g.us"
            };

            var whatsAppResponse = operation.GetDialog(request);
            if(!whatsAppResponse.IsSuccess) throw whatsAppResponse.Exception!;
            
            var actual = whatsAppResponse.GetResult();
    
            Console.WriteLine(actual?.ChatId);
            Console.WriteLine(actual?.ChatName);
            Console.WriteLine(actual?.ChatCreator);
            Console.WriteLine(actual?.ChatCreationDate);
            if (actual?.AdditionalChatInfo is {Participants: not null}) 
                foreach (var message in actual.AdditionalChatInfo?.Participants) 
                    Console.WriteLine(message.Body);
        }
    }
}
```
