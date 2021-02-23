# The appointment of a participant of the administrator group.
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

using WhatsAppApi.Core.Helpers;
using WhatsAppApi.Core.Connect;
using WhatsAppApi.Core.Connect.Interfaces;

using WhatsAppApi.Dialogs;
using WhatsAppApi.Dialogs.Interfaces;
using WhatsAppApi.Dialogs.SubOperations.Group.Requests;
using WhatsAppApi.Dialogs.SubOperations.Group.Requests.Interfaces;
using WhatsAppApi.Dialogs.SubOperations.Group.Responses.Interfaces;

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
            
            IPromoteGroupParticipantRequest request = new PromoteGroupParticipantRequest
            {
                ParticipantPhone = "+7(999) 111-11-11"// or ParticipantChatId = "79991111111@c.us"
            };

            var whatsAppResponse = operation.GroupOperations.PromoteParticipant(request);
            if (!whatsAppResponse.IsSuccess) Console.WriteLine(whatsAppResponse.Exception);
            var actual = whatsAppResponse.GetResult();

            Console.WriteLine(actual?.StatusMessage ?? actual?.ErrorMessage);
        }
    }
}
```



