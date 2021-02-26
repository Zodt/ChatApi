# Get the chat list.
**<span style="color:green">Implementation notes</span>** <br/>
The chat list includes avatars. <br/>
This method is available in both synchronous and asynchronous implementations

## Request
| `Parameter` | `Description`                        | `The data type of the parameter` | `Required parameter` |
|:-----------:|:-------------------------------------|:--------------------------------:|:--------------------:|
|  `Limit`  | Sets length of the message list. Default 100. <br/> With value 0 returns all messages. | `String` | <ul><li>- [ ] </li></ul> |
|  `Page`   | Page number, starts from 0, 0 by default. <br/> Example: 5 | `Integer` | <ul><li>- [ ] </li></ul> |


## Response
| `Parameter`           | `Description`                                           | `The data type of the parameter` | 
|:---------------------:|:--------------------------------------------------------|:--------------------------------:|
| `Dialogs`             | Collection of dialogs                                   | `DialogCollection`               |

###  Parameters of the `AdditionalChatInfo`
| `Parameter`           | `Description`                                           | `The data type of the parameter` | 
|:---------------------:|:--------------------------------------------------------|:--------------------------------:|
| `Image`               | HTTPS link on avatar or group image                     | `String`                         |
| `ChatId`              | The unique ID of the chat                               | `String`                         |
| `ChatName`            | The name of the chat                                    | `String`                         |
| `ChatCreator`         | The Creator of the chat                                 | `String`                         |
| `LastMessageTime`     | Date of last message in chat                            | `DateTime`                       |
| `ChatCreationDate`    | Date the chat was created                               | `DateTime`                       |
| `AdditionalChatInfo`  | Additional info about chat                              | `AdditionalChatInfo`             |

###  Parameters of the `AdditionalChatInfo`
| `Parameter`           | `Description`                                                        | `The data type of the parameter` | 
|:---------------------:|:---------------------------------------------------------------------|:--------------------------------:|
| `IsGroup`             | Flag indicating whether information was uploaded by group or by chat | `Boolean`                        |
| `Participants`        | Participants of the dialogue                                         | `ParticipantsCollection`         |
| `GroupInviteLink`     | Link to the invitation to the group                                  | `String`                         |

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
        internal static IWhatsAppConnect Connect { get; set; }

        internal static void Main()
        {
            // put your chat-api's data
            Connect = new WhatsAppConnect(WhatsApp_Server, WhatsApp_Instance, WhatsApp_Token); 
            IDialogOperations operation = new DialogOperations(Сonnect);
            
            var request = new DialogCollectionRequest
            {
                Limit = 1
            };
            
            IChatApiResponse<IDialogCollectionResponse?> chatApiResponse = dialogOperations.GetDialogs(request);
            if(!chatApiResponse.IsSuccess) throw chatApiResponse.Exception!;
            
            var response = chatApiResponse.GetResult();
            Console.WriteLine(response?.PrintMembers());
        }
    }
}
```
