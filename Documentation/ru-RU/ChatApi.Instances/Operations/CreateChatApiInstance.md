# Создание нового экземпляра ChatApi.
**<span style="color:green">Замечание по реализации</span>** <br/> 
Данный метод доступен как в синхронной, так и в асинхронной реализации.

## Параметры запроса
| `Параметр` | `Описание`                        | `Тип данных параметра` | `Обязательный параметр`  |
|:----------:|:----------------------------------|:----------------------:|:------------------------:|
|  `Type`    | Тип экземпляра                    | `ChatApiInstanceType`  | <ul><li>- [x] </li></ul> |

## Параметры ответа

|  `Параметр`           | `Описание`                                            | `Тип данных параметра` | 
|:---------------------:|:------------------------------------------------------|:----------------------:|
| `Result`              | Результат выполнения                                  | `IChatApiCreateInstanceResult`

## Параметры объекта `IChatApiCreateInstanceResult`
|  `Параметр`           | `Описание`                                            | `Тип данных параметра` | 
|:---------------------:|:------------------------------------------------------|:----------------------:|
| `Status`              | Статус выполнения операции                            | `ChatApiStatusOperation`
| `InstanceParameters`  | Параметры экземпляра                                  | `IChatApiInstanceParameters`

## Параметры объекта `IChatApiInstanceParameters`
|  `Параметр`           | `Описание`                                            | `Тип данных параметра` | 
|:---------------------:|:------------------------------------------------------|:----------------------:|
| `Id`     | Уникальный идентификатор экземпляра                                | `String`
| `ApiUrl` | Ссылка для обращений к серверу                                     | `String`
| `Token`  | Уникальный токен для обращений к серверу по данному экземпляру     | `String`


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
