# Получение текущего статуса аккаунта.
**<span style="color:green">Замечание по реализации</span>** <br/>
Повторная авторизация нужна только в случае смены устройства или ручного нажатия "Выйти из всех устройств" на телефоне. <br/> 
Держите приложение WhatsApp открытым во время авторизации. <br/>
Данный метод доступен как в синхронной, так и в асинхронной реализации.

## Параметры запроса
| `Параметр` | `Описание`                        | `Тип данных параметра` | `Обязательный параметр` |
|:----------:|:----------------------------------|:----------------------:|:-----------------------:|
|  `NoWakeup`  | Игнорировать автопробуждение аккаунта. | `Boolean` | <ul><li>- [ ] </li></ul> |
|  `GetFullInformation`  | Получить полную информацию о текущем статусе аккаунта. | `Boolean` | <ul><li>- [ ] </li></ul> |

## Параметры ответа
|  `Параметр`           | `Описание`                                            | `Тип данных параметра` | 
|:---------------------:|:------------------------------------------------------|:----------------------:|
|  `QrCode`             | QR-код в Base64.                                      | `String`               |            
|  `StatusData`         | Дополнительная информация о статусе аккаунта.         | `AccountStatusData`    |
|  `AccountStatus`      | Идентификатор статуса аккаунта.                       | `AccountStatusType`    |

###  Параметры объекта `AccountStatusData`
|  `Параметр`   | `Описание`                        | `Тип данных параметра`  | 
|:-------------:|:----------------------------------|:-----------------------:|
|  `Title`  | Название статуса на языке экземпляра. | `String` |
|  `Reason`  | Причина, по которой данный аккаунт находится в статусе "Loading". | `InstanceConnectionStatusType` |
|  `Actions`  | Действия, которые можно выполнить для изменения текущего статуса аккаунта. | `AdditionInformationStatus` |
|  `Message`  | Сообщение статуса на языке экземпляра. | `Boolean` |
|  `SubStatus`  | Доп. статус аккаунта. | `InstanceStatusType` |
|  `SubMessage`  | Дополнительное сообщение статуса на языке экземпляра. | `Boolean` |

###  Параметры объекта `AdditionInformationStatus`
|  `Параметр`   | `Описание`                        | `Тип данных параметра`  | 
|:-------------:|:----------------------------------|:-----------------------:|
|  `Retry`  | Включить или выключить автозагрузку видео из сообщений. | `InstanceStatus` |
|  `Expiry`  | Включить или выключить получение уведомлений о изменении чатов в webhook.. | `InstanceStatus` |
|  `Logout`  | Socks5 IP-адрес и порт прокси для аккаунта. <br/> ВАЖНО! Нерабочее прокси приведет к остановке работы аккаунта. | `InstanceStatus` |
|  `Takeover`  | Гарантийная доставка вебхука. Каждый вебхук будет делать 20 попыток отправки до получения 200го статуса от сервера. | `InstanceStatus` |
|  `LearnMore`  | Не отправлять вебхуки со старыми сообщениями (полученными с задержкой в 5 минут или oldMessagesPeriod секунд). | `InstanceStatus` |

###  Параметры объекта `InstanceStatus`
|  `Параметр`   | `Описание`                        | `Тип данных параметра`  | 
|:-------------:|:----------------------------------|:-----------------------:|
|  `Link`  | URL-адрес ссылки. | `String` |
|  `Label`  | Название ссылки для кнопки. | `String` |
|  `Action`  | Имя метода. | `InstanceStatusActionType` |

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
            IAccountOperation accountOperation = new AccountOperation(connect);

            var accountStatusRequest = new AccountStatusRequest
            {
                NoWakeup = true,
                GetFullInformation = true
            };
            var chatApiResponse = accountOperation.GetStatus(accountStatusRequest);

            if (!chatApiResponse.IsSuccess) throw chatApiResponse.Exception!;
            IAccountStatusResponse? response = chatApiResponse.GetResult();

            Console.WriteLine(response?.PrintMembers());
        }
    }
}
```
