# Removing an instance of the ChatApi.
**<span style="color:green">Implementation note</span>** <br/>
This method is available in both synchronous and asynchronous implementations.

## Request
| `Parameter` | `Description`                          | `The data type of the parameter` | `Required parameter`     |
|:-----------:|:---------------------------------------|:--------------------------------:|:------------------------:|
| `Instance`  | The unique identifier of the instance  | `String`                         | <ul><li>- [x] </li></ul> |

## Response
|  `Parameter`          | `Description`                                         | `The data type of the parameter` | 
|:---------------------:|:------------------------------------------------------|:--------------------------------:|
| `Status`              | The status of the operation                           | `ChatApiStatusOperation`

## Пример использования
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

            ChatApiRemoveInstanceRequest request = (ChatApiInstanceConnect)connect;
            request.Instance = "231564";
            
            var removeChatApiInstance = instanceOperations.RemoveChatApiInstance(request);
            if (!removeChatApiInstance.IsSuccess) return;
            var response = removeChatApiInstance.GetResult();

            Console.WriteLine(response?.Status);
            Console.WriteLine(response?.ErrorMessage);
        }
    }
}
```
