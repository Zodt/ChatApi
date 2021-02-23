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
            
            IDialogOperations operation = new DialogOperations(connect);

            IJoinGroupRequest request = new JoinGroupRequest
            {
                InvitationLink = "https://chat.whatsapp.com/GUF2kjFAFZKBRI8vhs2sqK"
            };

            var actionResult = operation.GroupOperations.JoinGroup(request);
            Console.WriteLine(actionResult.Exception);
            var actual = actionResult.GetResult();

            Console.WriteLine(actual?.ChatId ?? actual?.ErrorMessage);
        }
    }
}



