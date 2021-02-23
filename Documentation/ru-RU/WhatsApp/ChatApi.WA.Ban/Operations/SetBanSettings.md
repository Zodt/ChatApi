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

using WhatsAppApi.Connect;
using WhatsAppApi.Core.Helpers;

using WhatsAppApi.Core.Connect;
using WhatsAppApi.Core.Connect.Interfaces;

using WhatsAppApi.Messages.Requests;
using WhatsAppApi.Messages.Responses.Interfaces;

using WhatsAppApiClient.Properties;
namespace WhatsAppApiClient
{
    internal class Program
    {
        public static IWhatsAppConnect Connect { get; set; }

        private static void Main()
        {
            // put your chat-api's data
            Connect = new WhatsAppConnect(WhatsApp_Server, WhatsApp_Instance, WhatsApp_Token); 

            var banOperation = new BanOperation(Connect);
            
            IWhatsAppResponse<IBanSettingsResponse?> response = banOperation.SetBanSettings();
            if (response.IsSuccess) throw response.Exception!;

            var messageResponse = response.GetResult();
            Console.WriteLine(messageResponse!.IsSet);
        }
    }
}
```
