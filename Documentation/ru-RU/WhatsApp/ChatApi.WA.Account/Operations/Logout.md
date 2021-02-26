# Выход из аккаунта и запрос нового QR-кода.
**<span style="color:green">Замечание по реализации</span>** <br/>
Метод должен быть вызван в случае подключения к устройству другого экземпляра WhatsApp Web<br/>
Данный метод доступен как в синхронной, так и в асинхронной реализации.

## Параметры ответа
|  `Параметр`           | `Описание`                                            | `Тип данных параметра` | 
|:---------------------:|:------------------------------------------------------|:----------------------:|
|  `AccountStatus`      | Идентификатор статуса аккаунта.                       | `AccountStatusType` |

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

            var chatApiResponse = accountOperation.Logout();

            if (!chatApiResponse.IsSuccess) throw chatApiResponse.Exception!;
            var response = chatApiResponse.GetResult();

            Console.WriteLine(response?.PrintMembers());
        }
    }
}
```
