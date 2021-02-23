# Проверка наличия номера телефона в бан-листе
**<span style="color:green">Замечание по реализации</span>** <br/>
Данный метод доступен как в синхронной, так и в асинхронной реализации

## Параметры запроса
| `Параметр` | `Описание`                        | `Тип данных параметра` | `Обязательный параметр` |
|:----------:|:----------------------------------|:----------------------:|:-----------------------:|
|  `Phone`  |  Номер телефона, начинающийся с кода страны. <br/> Для России и Казахстана это всегда 7, затем 10 цифр. <br/> Сообщения на номера телефона с 8 не будут доставлены. <br/> Пример: "79995253422". | `String` | <ul><li>- [x] </li></ul> |

## Параметры ответа
|  `Параметр`   | `Описание`                        | `Тип данных параметра` | 
|:-------------:|:----------------------------------|:----------------------:|
|`Phone`| Проверяемый номер телефона | `String`
|`Banned`| Флаг, указывающий, что проверяемый номер телефона будет заблокирован автоматически | `Boolean`
|`Message`| Предупреждающее сообщение. <br/>Если установлено, то прежде, чем отправить блокировку, пользователю придет это сообщение. | `String`
|`BanPhoneMask` | Регулярное выражение, отбирающее телефонные номера для автоблокировки | `String` 

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
            
            IWhatsAppResponse<IBanSettingsResponse?> response = banOperation.CheckBan();
            if (response.IsSuccess) throw response.Exception!;

            var messageResponse = response.GetResult();
            Console.WriteLine(messageResponse!.IsBanned);
        }
    }
}
```
