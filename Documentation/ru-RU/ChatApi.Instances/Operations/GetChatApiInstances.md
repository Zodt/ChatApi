# Получение коллекции экземпляров ChatApi.
**<span style="color:green">Замечание по реализации</span>** <br/> 
Данный метод доступен как в синхронной, так и в асинхронной реализации.

## Параметры ответа

|  `Параметр`           | `Описание`                                            | `Тип данных параметра` | 
|:---------------------:|:------------------------------------------------------|:----------------------:|
| `InstanceCollection`  | Коллекция экземпляров                                 | `ChatApiInstanceCollection`

## Параметры объекта `ChatApiInstanceCollection`
|  `Параметр`           | `Описание`                                            | `Тип данных параметра` | 
|:---------------------:|:------------------------------------------------------|:----------------------:|
| `Name`                | Наименование экземпляра <br/> Может быть пустым       | `String`
| `ApiUrl`              | Ссылка для отправки запросов на сервер                | `String`
| `PaidTill`            | Дата окончания оплаченного периода                    | `DateTime`
| `Instance`            | Уникальный идентификатор экземпляра                   | `String`
| `IsActive`            | Показатель активности экземпляра                      | `Boolean`
| `TypeInstance`        | Тип экземпляра                                        | `ChatApiInstanceType`
| `PaymentsCount`       | Количество оплаченных месяцев                         | `Integer`

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
            
            IChatApiResponse<IChatApiInstanceCollectionResponse?> chatApiResponse = instanceOperations.GetChatApiInstances();
            if (!chatApiResponse.IsSuccess) throw chatApiResponse.Exception!;

            var response = chatApiResponse.GetResult();
            Console.WriteLine(response?.PrintMembers());
        }
    }
}
```
