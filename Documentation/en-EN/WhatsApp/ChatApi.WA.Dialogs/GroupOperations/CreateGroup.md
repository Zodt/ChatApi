# Creating the group.
**<span style="color:green">Implementation note</span>** <br/>
If the host is an iPhone, then the presence of all in the contact list is mandatory. <br/>
The group will be added to the queue for sending and created sooner or later, even if the phone is disconnected from the Internet or authorization is not passed. <br/>
Update from October 2, 2018: In the response, the chatId parameter will be filled in if it was possible to create a group on your phone within 20 seconds. <br/>
This method is available in both synchronous and asynchronous implementations.

## Request
| `Parameter` | `Description`                        | `The data type of the parameter` | `Required parameter` |
|:-----------:|:-------------------------------------|:--------------------------------:|:--------------------:|
| `Avatar`   | Group avatar 640x640px. <br/> Base64-encoded file with mime data | `String` | <ul><li>- [ ] </li></ul>
| `Phones`   | Collection of phone numbers of the members of the created group | `PhonesCollection` | <ul><li>- [x] Only Phones is specified</li><li>- [ ] Only ChatIds is specified</li></ul>
| `ChatIds`  | Collection of unique IDs of the members of the created group | `ChatIdsCollection` | <ul><li>- [x] Only ChatIds is specified</li><li>- [ ] Only Phones is specified</li></ul>
| `Preview`  | Group preview 96x96px. <br/> Base64-encoded file with mime data | `String` | <ul><li>- [ ] </li></ul>
| `GroupName`| Name of the group being created               | `String`               | <ul><li>- [x] </li></ul>
| `MessageText` | The text of the message that will be sent to the group when it is created. <br/> If you do not set a parameter, the message will not be sent. | `String` | <ul><li>- [ ] </li></ul>

## Response
| `Parameter`           | `Description`                                           | `The data type of the parameter` | 
|:---------------------:|:--------------------------------------------------------|:--------------------------------:|
| `Created`             | Flag for creating the group                             | `Boolean`
| `Message`             | Group creation status                                   | `String`
| `ChatId`              | Unique ID of the created group                          | `String`
| `GroupInviteLink`     | Link invitation to the group                            | `String`

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
       
            ICreateGroupRequest request = new CreateGroupRequest 
            {
                Phones = new PhonesCollection { "7(999) 111-11-11" }, // or ChatIds = new ChatIdsCollection{ "79991111111@c.us" },
                GroupName = "TestBotGroup",
                MessageText = "Test group was created",
            };
            
            IChatApiResponse<ICreateGroupResponse?> chatApiResponse = groupOperations.CreateGroup(request);
            if(!chatApiResponse.IsSuccess) throw chatApiResponse.Exception!;
            
            var response = chatApiResponse.GetResult();
            Console.WriteLine(response?.PrintMembers());
        }
    }
}
```



