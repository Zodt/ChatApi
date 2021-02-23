using ChatApi.Core.Helpers;
using ChatApi.WA.Account.Models.Interfaces;

namespace ChatApi.WA.Account.Models
{
    public class AccountSettings : IAccountSettings
    {
        #region Properties

        public string? ErrorMessage { get; set; }
        /// <summary>
        /// Задержка в секундах между получение запроса на отправку сообщения и его фактической отправкой
        /// </summary>
        public int? SendDelay { get; set; }
        /// <summary>
        /// Http или https URL для получения оповещений.
        /// </summary>
        public string? WebhookUrl { get; set; }
        /// <summary>
        /// Включить или выключить сбор данных об изменении статуса инстанса.
        /// </summary>
        public bool? InstanceStatuses { get; set; }
        /// <summary>
        /// Включить или выключить сбор данных о статусах вебхуков.
        /// </summary>
        public bool? WebhookStatuses { get; set; }
        /// <summary>
        /// Включить или выключить отправку вебхука при изменении статуса инстанса.
        /// </summary>
        public bool? StatusNotificationsOn { get; set; }
        /// <summary>
        /// Включить или выключить получение уведомлений о доставке и прочтении отправленных сообщений ack в webhook. Так же работает GET метод по тому же адресу.
        /// </summary>
        public bool? AckNotificationsOn { get; set; }
        /// <summary>
        /// Включить или выключить получение уведомлений о изменении чатов в webhook. Так же работает GET метод по тому же адресу.
        /// </summary>
        public bool? ChatUpdateOn { get; set; }
        /// <summary>
        /// Включить или выключить автозагрузку видео из сообщений.
        /// </summary>
        public bool? VideoUploadOn { get; set; }
        /// <summary>
        /// Socks5 IP-адрес и порт прокси для аккаунта. Нерабочее прокси приведет к остановке работы аккаунта
        /// </summary>
        public string? Proxy { get; set; }
        /// <summary>
        /// Гарантийная доставка вебхука. Каждый вебхук будет делать 20 попыток отправки до получения 200го статуса от сервера.
        /// </summary>
        public bool? GuaranteedHooks { get; set; }
        /// <summary>
        /// Не отправлять вебхуки со старыми сообщениями (полученными с задержкой в 5 минут или oldMessagesPeriod секунд).
        /// </summary>
        public bool? IgnoreOldMessages { get; set; }
        /// <summary>
        /// Время в секундах, после которого сообщение считается старым.
        /// </summary>
        public int? OldMessagesPeriod { get; set; }
        /// <summary>
        /// Обрабатывать сообщения из архивированных чатов.
        /// </summary>
        public bool? ProcessArchive { get; set; }
        /// <summary>
        /// Отключить/включить архивирование диалогов (может замедлить инстанс).
        /// </summary>
        public bool? DisableDialogsArchive { get; set; }
        /// <summary>
        /// Включает/отключает параллельную отправку хуков.
        /// </summary>
        public bool? ParallelHooks { get; set; }

        #endregion

        #region Equatable

        public bool Equals(IAccountSettings? other)
        {
            return other is not null &&  
                ErrorMessage == other.ErrorMessage && 
                   SendDelay == other.SendDelay && 
                   WebhookUrl == other.WebhookUrl && 
                   InstanceStatuses == other.InstanceStatuses && 
                   WebhookStatuses == other.WebhookStatuses && 
                   StatusNotificationsOn == other.StatusNotificationsOn && 
                   AckNotificationsOn == other.AckNotificationsOn && 
                   ChatUpdateOn == other.ChatUpdateOn && 
                   VideoUploadOn == other.VideoUploadOn && 
                   Proxy == other.Proxy && 
                   GuaranteedHooks == other.GuaranteedHooks && 
                   IgnoreOldMessages == other.IgnoreOldMessages && 
                   OldMessagesPeriod == other.OldMessagesPeriod && 
                   ProcessArchive == other.ProcessArchive && 
                   DisableDialogsArchive == other.DisableDialogsArchive && 
                   ParallelHooks == other.ParallelHooks;
        }

        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is IAccountSettings other && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = ErrorMessage != null ? ErrorMessage.GetHashCode() : 0;
                hashCode = (hashCode * 397) ^ SendDelay.GetHashCode();
                hashCode = (hashCode * 397) ^ (WebhookUrl != null ? WebhookUrl.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ InstanceStatuses.GetHashCode();
                hashCode = (hashCode * 397) ^ WebhookStatuses.GetHashCode();
                hashCode = (hashCode * 397) ^ StatusNotificationsOn.GetHashCode();
                hashCode = (hashCode * 397) ^ AckNotificationsOn.GetHashCode();
                hashCode = (hashCode * 397) ^ ChatUpdateOn.GetHashCode();
                hashCode = (hashCode * 397) ^ VideoUploadOn.GetHashCode();
                hashCode = (hashCode * 397) ^ (Proxy != null ? Proxy.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ GuaranteedHooks.GetHashCode();
                hashCode = (hashCode * 397) ^ IgnoreOldMessages.GetHashCode();
                hashCode = (hashCode * 397) ^ OldMessagesPeriod.GetHashCode();
                hashCode = (hashCode * 397) ^ ProcessArchive.GetHashCode();
                hashCode = (hashCode * 397) ^ DisableDialogsArchive.GetHashCode();
                hashCode = (hashCode * 397) ^ ParallelHooks.GetHashCode();
                return hashCode;
            }
        }

        public static bool operator == (AccountSettings? left, AccountSettings? right) => EquatableHelper.IsEquatable(left, right);
        public static bool operator != (AccountSettings? left, AccountSettings? right) => !EquatableHelper.IsEquatable(left, right);

        #endregion
    }
}