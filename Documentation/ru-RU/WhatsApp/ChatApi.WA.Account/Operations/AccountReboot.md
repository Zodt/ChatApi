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
            IDialogOperations operation = new DialogOperations(Сonnect);
            
            IDialogRequest request = new DialogRequest
            {
                ChatId = "17472822486-1603286775@g.us"
            };

            var whatsAppResponse = operation.GetDialog(request);
            if(!whatsAppResponse.IsSuccess) throw whatsAppResponse.Exception!;
            
            var actual = whatsAppResponse.GetResult();
    
            Console.WriteLine(actual?.ChatId);
            Console.WriteLine(actual?.ChatName);
            Console.WriteLine(actual?.ChatCreator);
            Console.WriteLine(actual?.ChatCreationDate);
            if (actual?.AdditionalChatInfo is {Participants: not null}) 
                foreach (var message in actual.AdditionalChatInfo?.Participants) 
                    Console.WriteLine(message.Body);
        }
    }
}
```
