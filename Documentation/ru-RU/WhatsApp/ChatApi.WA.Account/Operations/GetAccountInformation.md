# Получение информации об аккаунте.
**<span style="color:green">Замечание по реализации</span>** <br/>
Данный метод доступен как в синхронной, так и в асинхронной реализации.

## Параметры ответа
|  `Параметр`           | `Описание`                                            | `Тип данных параметра` | 
|:---------------------:|:------------------------------------------------------|:----------------------:|
|  `Id`                 | Уникальный идентификатор чата аккаунта.               | `String`               |
|  `Battery`            | Процент заряда батареи.                               | `String`               |
|  `Locale`             | Локализация.                                          | `String`               |
|  `Name`               | Наименование аккаунта.                                | `String`               |
|  `WhatsAppVersion`    | Версия установленного приложения WhatsApp на телефоне владельца аккаунта.            | `String`               |
|  `Device`             | Информация о телефоне владельца аккаунта.             | `DeviceCharacteristic`               |

## Параметры объекта `DeviceCharacteristic`
|  `Параметр`           | `Описание`                                            | `Тип данных параметра` | 
|:---------------------:|:------------------------------------------------------|:----------------------:|
|  `Model`              | Модель телефона владельца аккаунта.                   | `String`               |
|  `Manufacturer`       | Производитель телефона владельца аккаунта.            | `String`               |
|  `OsVersion`          | Версия операционной системы на телефоне владельца учетной записи. | `String`               |

## Пример использования
```csharp
using System;

using ChatApi.Core.Connect;
using ChatApi.Core.Connect.Interfaces;

using ChatApi.WA.Account;

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

            var chatApiResponse = accountOperation.GetAccountInformation();

            if (!chatApiResponse.IsSuccess) throw chatApiResponse.Exception!;
            var response = chatApiResponse.GetResult();

            Console.WriteLine(response?.PrintMembers());
        }
    }
}
```
