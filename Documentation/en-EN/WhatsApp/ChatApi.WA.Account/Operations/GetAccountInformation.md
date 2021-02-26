# Getting information about the account.
**<span style="color:green">Implementation notes</span>**<br/>
This method is available in both synchronous and asynchronous implementations

## Response
| `Parameter`           | `Description`                                           | `The data type of the parameter` | 
|:---------------------:|:--------------------------------------------------------|:--------------------------------:|
|  `Id`                 | The unique ID of the chat account.            | `String`               |
|  `Battery`            | The percentage of battery charge.                              | `String`               |
|  `Locale`             | Culture                                          | `String`               |
|  `Name`               | Name of the account.                                | `String`               |
|  `WhatsAppVersion`    | The version of the installed WhatsApp app on the account owner's phone.            | `String`               |
|  `Device`             | Information about the phone number of the account owner.             | `DeviceCharacteristic`               |

## Parameters of the `DeviceCharacteristic`
| `Parameter`           | `Description`                                           | `The data type of the parameter` | 
|:---------------------:|:--------------------------------------------------------|:--------------------------------:|
|  `Model`              | The phone model of the account holder.                      | `String`               |
|  `Manufacturer`       | The manufacturer of the account owner's phone number.            | `String`               |
|  `OsVersion`          | The version of the operating system on the account owner's phone. | `String`               |

## Example
```csharp
using System;

using ChatApi.Core.Connect;
using ChatApi.Core.Connect.Interfaces;

using ChatApi.WA.Account;

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

            var chatApiResponse = accountOperation.GetAccountInformation();

            if (!chatApiResponse.IsSuccess) throw chatApiResponse.Exception!;
            var response = chatApiResponse.GetResult();

            Console.WriteLine(response?.PrintMembers());
        }
    }
}
```
