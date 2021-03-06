# Restart your WhatsApp account.
**<span style="color:green">Implementation notes</span>**<br/>
This method is available in both synchronous and asynchronous implementations

## Response
| `Parameter`           | `Description`                                           | `The data type of the parameter` | 
|:---------------------:|:--------------------------------------------------------|:--------------------------------:|
| `Success`             | The result of the request                               | `Boolean`

## Example
```csharp
using System;

using ChatApi.Core.Connect;
using ChatApi.Core.Connect.Interfaces;

using ChatApi.WA.Account;
using ChatApi.WA.Account.Requests;

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
            IAccountOperation accountOperation = new AccountOperation(connect);

            var chatApiResponse = accountOperation.AccountReboot();
            
            if (!chatApiResponse.IsSuccess) throw chatApiResponse.Exception!;
            var response = chatApiResponse.GetResult();
            
            Console.WriteLine(response?.PrintMembers());
        }
    }
}
```
