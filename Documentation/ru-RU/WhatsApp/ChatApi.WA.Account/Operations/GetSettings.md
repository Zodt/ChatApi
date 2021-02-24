# Получение настроек аккаунта.
**<span style="color:green">Замечание по реализации</span>** <br/>
Данный метод доступен как в синхронной, так и в асинхронной реализации.

## Параметры ответа
|  `Параметр`           | `Описание`                                            | `Тип данных параметра` | 
|:---------------------:|:------------------------------------------------------|:----------------------:|
|  `SendDelay`  | Задержка в секундах между получение запроса на отправку сообщения и его фактической отправкой. | `Integer` |
|  `WebhookUrl`  | Http или https URL для получения оповещений. | `String` |
|  `InstanceStatuses`  | Включить или выключить сбор данных об изменении статуса инстанса. | `Boolean` |
|  `WebhookStatuses`  | Включить или выключить сбор данных о статусах вебхуков. | `Boolean` |
|  `StatusNotificationsOn`  | Включить или выключить отправку вебхука при изменении статуса инстанса. | `Boolean` |
|  `AckNotificationsOn`  | Включить или выключить получение уведомлений о доставке и прочтении отправленных сообщений ack в webhook. | `Boolean` |
|  `ChatUpdateOn`  | Включить или выключить получение уведомлений о изменении чатов в webhook.. | `Boolean` |
|  `VideoUploadOn`  | Включить или выключить автозагрузку видео из сообщений. | `Boolean` |
|  `Proxy`  | Socks5 IP-адрес и порт прокси для аккаунта. <br/> ВАЖНО! Нерабочее прокси приведет к остановке работы аккаунта. | `String` |
|  `GuaranteedHooks`  | Гарантийная доставка вебхука. Каждый вебхук будет делать 20 попыток отправки до получения 200го статуса от сервера. | `Boolean` |
|  `IgnoreOldMessages`  | Не отправлять вебхуки со старыми сообщениями (полученными с задержкой в 5 минут или oldMessagesPeriod секунд). | `Boolean` |
|  `OldMessagesPeriod`  | Время в секундах, после которого сообщение считается старым. | `Integer` |
|  `ProcessArchive`  | Обрабатывать сообщения из архивированных чатов. | `Boolean` |
|  `DisableDialogsArchive`  | Отключить/включить архивирование диалогов (может замедлить инстанс). | `Boolean` |
|  `ParallelHooks`  | Включает/отключает параллельную отправку хуков. | `Boolean` |

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

            var chatApiResponse = accountOperation.GetSettings();

            if (!chatApiResponse.IsSuccess) throw chatApiResponse.Exception!;
            IAccountSettingsResponse? response = chatApiResponse.GetResult();

            Console.WriteLine(response?.PrintMembers());
        }
    }
}
```
