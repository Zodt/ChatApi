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

using ChatApi.Core.Connect;
using ChatApi.Core.Connect.Interfaces;
using ChatApi.Core.Response.Interfaces;

using ChatApi.WA.Dialogs;
using ChatApi.WA.Dialogs.Requests;
using ChatApi.WA.Dialogs.Responses.Interfaces;

using ChatApiClient.Properties;
namespace ChatApiClient
{
    internal class Program
    {
        public static IWhatsAppConnect Connect { get; set; }

        private static void Main()
        {
            // put your chat-api's data
            Connect = new WhatsAppConnect(WhatsApp_Server, WhatsApp_Instance, WhatsApp_Token); 
            IDialogOperations dialogOperations = new DialogOperations(Connect);

            var dialogRequest = new DialogRequest
            {
                ChatId = "17472822486-1603286775@g.us"
            };

            var chatApiResponse = dialogOperations.GetDialog(dialogRequest);
            if (!chatApiResponse.IsSuccess) throw chatApiResponse.Exception!;

            var response = chatApiResponse.GetResult();
            Console.WriteLine(response?.PrintMembers());
        }
    }
}
```
