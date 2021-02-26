# Перезагрузка аккаунта WhatsApp.
**<span style="color:green">Замечание по реализации</span>** <br/>
Данный метод доступен как в синхронной, так и в асинхронной реализации.

## Параметры ответа

|  `Параметр`           | `Описание`                                            | `Тип данных параметра` | 
|:---------------------:|:------------------------------------------------------|:----------------------:|
| `Success`             | Результат выполнения запроса                          | `Boolean`


## Пример использования
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
