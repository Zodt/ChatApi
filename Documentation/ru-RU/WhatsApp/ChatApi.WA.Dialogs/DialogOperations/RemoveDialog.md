# Удаление диалога.
**<span style="color:green">Замечания по реализации</span>** <br/>
Данный метод доступен как в синхронной, так и в асинхронной реализации

## Параметры запроса
| `Параметр` | `Описание`                        | `Тип данных параметра` | `Обязательный параметр` |
|:----------:|:----------------------------------|:----------------------:|:-----------------------:|
|  `Phone`   | Номер телефона, начинающийся с кода страны. <br/> Для России и Казахстана это всегда 7, затем 10 цифр. <br/> Сообщения на номера телефона с 8 не будут доставлены. <br/> Пример: "79995253422". | `String` | <ul><li>- [x] Указан только Phone</li><li>- [ ] Указан только ChatId</li></ul> |
|  `ChatId`  | ID чата из списка сообщений. <br/> Примеры: <br/> 17633123456@c.us для личных сообщений<br/> 17680561234-1479621234@g.us для группы. | `String` | <ul><li>- [x] Указан только ChatId</li><li>- [ ] Указан только Phone</li></ul> |


## Параметры ответа
|  `Параметр`   | `Описание`                        | `Тип данных параметра` | 
|:-------------:|:----------------------------------|:----------------------:|
| `Result`      | Результат запроса                 |`OperationMessageResult`|


###  Параметры объекта `OperationMessageResult`
|  `Параметр`   | `Описание`                        | `Тип данных параметра` | 
|:-------------:|:----------------------------------|:----------------------:|
| `Message`     | Результат запроса                 | `String`               |



## Example
```csharp
using System;

using WhatsAppApi.Core.Helpers;
using WhatsAppApi.Core.Connect;
using WhatsAppApi.Core.Connect.Interfaces;

using WhatsAppApi.Dialogs;
using WhatsAppApi.Dialogs.Interfaces;
using WhatsAppApi.Dialogs.Responses.Interfaces;

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
            IDialogOperations operation = new DialogOperations(Сonnect);
            
            IOperationMessageResult request = new OperationMessageResult
            {
                Phone = "7(999) 111-11-11" // or "79991111111@c.us"
            };
            
            var actionResult = operation.RemoveDialog(request);
            if(!actionResult.IsSuccess) throw actionResult.Exception!;
            
            var actual = actionResult.GetResult();
    
            if (actual?.Result is null) return;
            Console.WriteLine(actual.Result?.Message);
        }
    }
}
```
