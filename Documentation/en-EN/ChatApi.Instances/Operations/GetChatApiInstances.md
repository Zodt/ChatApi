# Getting a collection of ChatApi instances.
**<span style="color:green">Implementation note</span>** <br/>
This method is available in both synchronous and asynchronous implementations.

## Response
|  `Parameter`          | `Description`                                         | `The data type of the parameter` | 
|:---------------------:|:------------------------------------------------------|:--------------------------------:|
| `InstanceCollection`  | Collection of instances                               | `ChatApiInstanceCollection`

## Parameters of the `ChatApiInstanceCollection`
|  `Parameter`          | `Description`                                         | `The data type of the parameter` | 
|:---------------------:|:------------------------------------------------------|:--------------------------------:|
| `Name`                | The name of the instance <br/> Can be empty           | `String`
| `ApiUrl`              | Link for accessing the server                         | `String`
| `PaidTill`            | End date of the paid period                           | `DateTime`
| `Instance`            | The unique identifier of the instance                 | `String`
| `IsActive`            | An indicator of the activity instance                 | `Boolean`
| `TypeInstance`        | Instance t ype                                        | `ChatApiInstanceType`
| `PaymentsCount`       | Number of paid months                                 | `Integer`

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
            
            IChatApiResponse<IChatApiInstanceCollectionResponse?> chatApiResponse = instanceOperations.GetChatApiInstances();
            if (!chatApiResponse.IsSuccess) throw chatApiResponse.Exception!;

            var response = chatApiResponse.GetResult();
            Console.WriteLine(response?.PrintMembers());
        }
    }
}
```
