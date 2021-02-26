# Получение QR-кода.
**<span style="color:green">Замечание по реализации</span>** <br/>
Возвращает файл изображения QR-кода в формате png.<br/>
Данный метод доступен только в асинхронной реализации.

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
        internal static IWhatsAppConnect Connect { get; set; }

        internal static async Task Main()
        {
            // put your chat-api's data
            Connect = new WhatsAppConnect(WhatsApp_Server, WhatsApp_Instance, WhatsApp_Token); 
            IAccountOperation accountOperation = new AccountOperation(connect);

            IChatApiResponse<IQrCodeResponse?>? chatApiResponse = await accountOperation.GetQrCodeAsync().ConfigureAwait(true);

            if (!chatApiResponse.IsSuccess) throw chatApiResponse.Exception!;
            var response = chatApiResponse.GetResult();
            
            Console.WriteLine(response?.PrintMembers());
        }
    }
}
```
