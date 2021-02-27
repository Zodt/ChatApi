# Удаление экземпляра ChatApi.
**<span style="color:green">Замечание по реализации</span>** <br/> 
Данный метод доступен как в синхронной, так и в асинхронной реализации.

## Параметры запроса
| `Параметр` | `Описание`                        | `Тип данных параметра` | `Обязательный параметр`  |
|:----------:|:----------------------------------|:----------------------:|:------------------------:|
|  `Instance`    | Уникальный идентификатор экземпляра                    | `String`  | <ul><li>- [x] </li></ul> |

## Параметры ответа

|  `Параметр`           | `Описание`                                            | `Тип данных параметра` | 
|:---------------------:|:------------------------------------------------------|:----------------------:|
| `Status`              | Статус выполнения операции                            | `ChatApiStatusOperation`

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
            if (!chatApiResponse.IsSuccess) throw chatApiResponse.Exception!;

            var response = chatApiResponse.GetResult();
            Console.WriteLine(response?.PrintMembers());
        }
    }
}
```
