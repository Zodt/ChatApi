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
            Connect = new WhatsAppConnect(WhatsApp_Server, WhatsApp_Instance, WhatsApp_Token); 
            IBanOperations banOperations = new BanOperations(connect);

            var request = new CheckBanRequest
            {
                Phone = "7(999) 111-11-11"
            };
            IChatApiResponse<ICheckBanResponse?>? chatApiResponse = banOperations.CheckBan(request);
            
            if (!chatApiResponse.IsSuccess) throw chatApiResponse.Exception!;
            var response = chatApiResponse.GetResult();
            
            Console.WriteLine(response?.PrintMembers());
        }
    }
}
```
