# Изменение текущих настроек автоблокировки
**<span style="color:green">Замечание по реализации</span>** <br/>
Данный метод доступен как в синхронной, так и в асинхронной реализации

## Параметры запроса
| `Параметр` | `Описание`                        | `Тип данных параметра` | `Обязательный параметр` |
|:----------:|:----------------------------------|:----------------------:|:-----------------------:|
|`Set`          | Флаг, указывающий, что текущий запрос изменил настройки автоблокировки. | `Boolean` | <ul><li>- [x] </li></ul> |
|`BanPhoneMask` | Регулярное выражение, отбирающее телефонные номера для автоблокировки. | `String`| <ul><li>- [x] </li></ul> |
|`PreBanMessage`| Предупреждающее сообщение. <br/>Если установлено, то прежде, чем отправить блокировку, пользователю придет это сообщение. | `String`| <ul><li>- [x] </li></ul> |


## Параметры ответа
|  `Параметр`   | `Описание`                        | `Тип данных параметра` | 
|:-------------:|:----------------------------------|:----------------------:|
|`Set`          | Флаг, указывающий, что текущий запрос изменил настройки автоблокировки. | `Boolean` |
|`BanPhoneMask` | Регулярное выражение, отбирающее телефонные номера для автоблокировки. | `String`|
|`PreBanMessage`| Предупреждающее сообщение. <br/>Если установлено, то прежде, чем отправить блокировку, пользователю придет это сообщение. | `String`|

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
            IBanOperations banOperations = new BanOperations(Connect);
            
            var banSettings = new BanSettingRequest()
            {
                BanPhoneMask = @"^\\(?([0-9]{3})\\)?[-.●]?([0-9]{3})[-.●]?([0-9]{4})$",
                PreBanMessage = @"Do not write to me, otherwise I will send you a ban"
            };
            
            IChatApiResponse<IBanSettingsResponse?> chatApiResponse = banOperation.SetBanSettings(banSettings);
            if (chatApiResponse.IsSuccess) throw chatApiResponse.Exception!;

            IBanSettingsResponse? response = chatApiResponse.GetResult();
            Console.WriteLine(response?.PrintMembers());
        }
    }
}
```