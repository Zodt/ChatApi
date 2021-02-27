# Creating a new instance of the Chat Api.
**<span style="color:green">Implementation note</span>** <br/>
This method is available in both synchronous and asynchronous implementations.

## Request
| `Parameter` | `Description`                        | `The data type of the parameter` | `Required parameter`     |
|:-----------:|:-------------------------------------|:--------------------------------:|:------------------------:|
|  `Type`     | Instance type                        | `ChatApiInstanceType`            | <ul><li>- [x] </li></ul> |

## Response
|  `Parameter`          | `Description`              | `The data type of the parameter` | 
|:---------------------:|:---------------------------|:--------------------------------:|
| `Result`              | Execution result           | `IChatApiCreateInstanceResult`

## Parameters of the `IChatApiCreateInstanceResult`
|  `Parameter`           | `Description`                                        | `The data type of the parameter` | 
|:---------------------:|:------------------------------------------------------|:--------------------------------:|
| `Status`              | The status of the operation                           | `ChatApiStatusOperation`
| `InstanceParameters`  | Parameters of the instance                            | `IChatApiInstanceParameters`

## Parameters of the `IChatApiInstanceParameters`
|  `Parameter`           | `Description`                                             | `The data type of the parameter` | 
|:----------------------:|:----------------------------------------------------------|:--------------------------------:|
| `Id`                   | The unique identifier of the instance                     | `String`
| `ApiUrl`               | Link for accessing the server                             | `String`
| `Token`                | A unique token for accessing the server for this instance | `String`


## Example
```csharp
using System;

using ChatApi.Core.Connect.Interfaces;
using ChatApi.Core.Response.Interfaces;

using ChatApi.Instances;
using ChatApi.Instances.Models;
using ChatApi.Instances.Connect;

using ChatApi.Instances.Requests;
using ChatApi.Instances.Requests.Interfaces;
using ChatApi.Instances.Responses.Interfaces;

namespace ChatApiClient
{
    internal static class Program
    {
        internal static void Main()
        {
            IChatApiInstanceConnect connect = new ChatApiInstanceConnect("ApiKey");
            IChatApiInstanceOperations instanceOperations = new ChatApiInstanceOperations(connect);

            IChatApiCreateInstanceRequest request = new ChatApiCreateInstanceRequest
            {
                Type = ChatApiInstanceType.WhatsAppDev
            };
            
            IChatApiResponse<IChatApiCreateInstanceResponse?> chatApiResponse = instanceOperations.CreateChatApiInstance(request);
            if (!chatApiResponse.IsSuccess) throw chatApiResponse.Exception!;

            var response = chatApiResponse.GetResult();
            Console.WriteLine(response?.PrintMembers());
        }
    }
}
```
