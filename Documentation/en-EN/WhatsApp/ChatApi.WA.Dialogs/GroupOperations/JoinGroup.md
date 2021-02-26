# Joining the group.
**<span style="color:green">Implementation note</span>** <br/>
This method is available in both synchronous and asynchronous implementations.

## Request
| `Parameter` | `Description`                        | `The data type of the parameter` | `Required parameter` |
|:-----------:|:-------------------------------------|:--------------------------------:|:--------------------:|
| `InvitationCode`   | Code from the invitation link | `String` | <ul><li>- [x] Only InvitationCode is specified</li><li>- [ ] Only InvitationLink is specified</li></ul>
| `InvitationLink`  | An invitation link from the group information. | `String` | <ul><li>- [x] Only InvitationLink is specified</li><li>- [ ] Only InvitationCode is specified</li></ul>

## Response
| `Parameter`           | `Description`                                           | `The data type of the parameter` | 
|:---------------------:|:--------------------------------------------------------|:--------------------------------:|
| `ChatId`              | Unique ID of the group                                  | `String`

## Example
```csharp
using System;

using ChatApi.Core.Connect;
using ChatApi.Core.Connect.Interfaces;
using ChatApi.Core.Response.Interfaces;

using ChatApi.WA.Dialogs;
using ChatApi.WA.Dialogs.Helpers.Collections;
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

            IJoinGroupRequest request = new JoinGroupRequest
            {
                InvitationLink = "https://chat.whatsapp.com/GUF2kjFAFZKBRI8vhs2sqK"
            };

            var chatApiResponse = groupOperations.JoinGroup(request);
            if(!chatApiResponse.IsSuccess) throw chatApiResponse.Exception!;
            
            var response = chatApiResponse.GetResult();
            Console.WriteLine(response?.PrintMembers());
        }
    }
}
```


