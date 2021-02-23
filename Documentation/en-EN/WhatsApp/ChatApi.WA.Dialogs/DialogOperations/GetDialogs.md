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
            
            IDialogCollectionRequest request = new DialogCollectionRequest
            {
                Limit = 1
            };
            
            var actionResult = operation.GetDialogs(request);
            if(!actionResult.IsSuccess) throw actionResult.Exception!;
            
            var actual = actionResult.GetResult();
    
            if (actual?.Dialogs is null) return;
            foreach (var dialog in actual.Dialogs)
            {
                Console.WriteLine(dialog.ChatId);
                Console.WriteLine(dialog.ChatName);
                Console.WriteLine(dialog.ChatCreator);
                Console.WriteLine(dialog.ChatCreationDate);
                Console.WriteLine(dialog.LastMessageTime);
                Console.WriteLine(dialog.Image);
                Console.WriteLine(dialog.AdditionalChatInfo?.IsGroup);
                Console.WriteLine(dialog.AdditionalChatInfo?.GroupInviteLink);

                Console.WriteLine("\n'Participants'");
                if (dialog?.AdditionalChatInfo is not {Participants: not null}) return;
                foreach (string participant in dialog.AdditionalChatInfo?.Participants!) Console.WriteLine(participant);
            }
        }
    }
}
```
