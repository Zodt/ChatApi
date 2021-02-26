# Depriving a participant of the group administration rights.
**<span style="color:green">Implementation note</span>** <br/>
This method is available in both synchronous and asynchronous implementations.

## Request
| `Parameter` | `Description`                        | `The data type of the parameter` | `Required parameter` |
|:-----------:|:-------------------------------------|:--------------------------------:|:--------------------:|
| `GroupId`   | Unique ID of the group | `String` | <ul><li>- [ ] </li></ul>
| `ParticipantPhone`   | The phone number of the participant being added to the group | `String` | <ul><li>- [x] Only ParticipantPhone is specified</li><li>- [ ] Only ParticipantChatId is specified</li></ul>
| `ParticipantChatId`  | Unique ID of the participant to add to the group | `String` | <ul><li>- [x] Only ParticipantChatId is specified</li><li>- [ ] Only ParticipantPhone is specified</li></ul>

## Response
| `Parameter`           | `Description`                                           | `The data type of the parameter` | 
|:---------------------:|:--------------------------------------------------------|:--------------------------------:|
| `GroupId`             | Unique ID of the group                                  | `String`
| `IsSuccess`           | Flag for adding a participant to the group              | `Boolean`
| `StatusMessage`       | Status of adding a participant to the group             | `String`

## Example
```csharp
using System;

using ChatApi.Core.Connect;
using ChatApi.Core.Connect.Interfaces;
using ChatApi.Core.Response.Interfaces;

using ChatApi.WA.Dialogs;
using ChatApi.WA.Dialogs.Operations.Interfaces;

using ChatApi.WA.Dialogs.Requests;
using ChatApi.WA.Dialogs.Requests.Interfaces;
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
            IDialogOperations operation = new DialogOperations(Connect);
            IGroupOperations groupOperations = operation.GroupOperations.Value;
            IGroupParticipantOperations participantOperations = groupOperations.GroupParticipantOperations.Value;
            
            IDemoteGroupParticipantRequest request = new DemoteGroupParticipantRequest
            {
                ParticipantPhone = "+7(999) 111-11-11"// or ParticipantChatId = "79991111111@c.us"
            };

            var chatApiResponse = participantOperations.DemoteParticipant(request);
            if (!chatApiResponse.IsSuccess) throw chatApiResponse.Exception!;

            var response = chatApiResponse.GetResult();
            Console.WriteLine(response?.PrintMembers());
        }
    }
}
```



