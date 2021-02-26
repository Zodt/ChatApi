# Получение настройки автоблокировки
**<span style="color:green">Замечание по реализации</span>** <br/>
Данный метод доступен как в синхронной, так и в асинхронной реализации

## Параметры ответа
|  `Параметр`   | `Описание`                        | `Тип данных параметра` | 
|:-------------:|:----------------------------------|:----------------------:|
|`Set`          | Флаг, указывающий, что текущий запрос изменил настройки автоблокировки | `Boolean`
|`BanPhoneMask` | Регулярное выражение, отбирающее телефонные номера для автоблокировки | `String` 
|`PreBanMessage`| Предупреждающее сообщение. <br/>Если установлено, то прежде, чем отправить блокировку, пользователю придет это сообщение. | `String`

## Пример использования
```csharp
using System;

using ChatApi.Core.Connect;
using ChatApi.Core.Connect.Interfaces;
using ChatApi.Core.Response.Interfaces;

using ChatApi.WA.Ban;
using ChatApi.WA.Ban.Requests;
using ChatApi.WA.Ban.Responses.Interfaces;

using ChatApiClient.Properties;
namespace ChatApiClient
{
    internal class Program
    {
        internal static IWhatsAppConnect Connect { get; set; }

        internal static void Main()
        {
            // put your chat-api's data
            Connect = new WhatsAppConnect(WhatsApp_Server, WhatsApp_Instance, WhatsApp_Token); 
            IBanOperations banOperations = new BanOperations(connect);
            
            IChatApiResponse<IBanSettingsResponse?> chatApiResponse = banOperations.GetBanSettings();
            if (!chatApiResponse.IsSuccess) throw response.Exception!;

            var response = chatApiResponse.GetResult();
            Console.WriteLine(response?.PrintMembers());
        }
    }
}
```