# Getting the current account status.
**<span style="color:green">Implementation notes</span>** <br/>
Re-authorization is only required if you change the device or manually click "Log out of all devices" on the phone. <br/>
Keep the WhatsApp app open during authorization. <br/>
This method is available in both synchronous and asynchronous implementations

## Request
| `Parameter` | `Description`                        | `The data type of the parameter` | `Required parameter` |
|:-----------:|:-------------------------------------|:--------------------------------:|:--------------------:|
|  `NoWakeup`  | Ignore autowakeup. <br/> Default - false  | `Boolean` | <ul><li>- [ ] </li></ul> |
|  `GetFullInformation`  | Get full information on the current status. <br/> Default - false | `Boolean` | <ul><li>- [ ] </li></ul> |

## Response
| `Parameter`       | `Description`                                | `The data type of the parameter` | 
|:-----------------:|:---------------------------------------------|:--------------------------------:|
|  `QrCode`         | Base64-encoded contents of the QR code.      | `String`                         |            
|  `StatusData`     | Additional information about account status. | `AccountStatusData`              |
|  `AccountStatus`  | Account Status.                              | `AccountStatusType`              |

## Parameters of the `AccountStatusData`
| `Parameter`           | `Description`                                           | `The data type of the parameter` | 
|:---------------------:|:--------------------------------------------------------|:--------------------------------:|
|  `Title`  | Status title in the language of the account. | `String` |
|  `Reason`  | The reason why the account is in "loading" status. | `InstanceConnectionStatusType` |
|  `Actions`  | Actions that can be applied to change the status. | `AdditionInformationStatus` |
|  `Message`  | Status message in the language of the account. | `Boolean` |
|  `SubStatus`  | Account substatus. | `InstanceStatusType` |
|  `SubMessage`  | Additional status message in the language of the account. | `Boolean` |

## Parameters of the `AdditionInformationStatus`
| `Parameter`           | `Description`                                           | `The data type of the parameter` | 
|:---------------------:|:--------------------------------------------------------|:--------------------------------:|
|  `Retry`  | Repeat the manual synchronization attempt with the device. | `InstanceStatus` |
|  `Expiry`  | Updates the QR code after its expired. | `InstanceStatus` |
|  `Logout`  | Logout from WhatsApp Web to get new QR code. | `InstanceStatus` |
|  `Takeover`  | Returns the active session. | `InstanceStatus` |
|  `LearnMore`  | Getting additional information about acceptable transactions in this account status. | `InstanceStatus` |

## Parameters of the `InstanceStatus`
| `Parameter`           | `Description`                                           | `The data type of the parameter` | 
|:---------------------:|:--------------------------------------------------------|:--------------------------------:|
|  `Link`  | Reference URL instead of method. | `String` |
|  `Label`  | Action caption for the button. | `String` |
|  `Action`  | Method name. | `InstanceStatusActionType` |

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

            var accountStatusRequest = new AccountStatusRequest
            {
                NoWakeup = true,
                GetFullInformation = true
            };
            var chatApiResponse = accountOperation.GetStatus(accountStatusRequest);

            if (!chatApiResponse.IsSuccess) throw chatApiResponse.Exception!;
            IAccountStatusResponse? response = chatApiResponse.GetResult();

            Console.WriteLine(response?.PrintMembers());
        }
    }
}
```
