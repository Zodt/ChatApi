using ChatApi.WA.Account.Models.Interfaces;

namespace ChatApi.WA.Account.Models
{
    /// <summary/>
    public record AccountSettings : IAccountSettings
    {

        #region Properties

        /// <inheritdoc />
        public string? ErrorMessage { get; set; }

        /// <inheritdoc />
        public int? SendDelay { get; set; }

        /// <inheritdoc />
        public string? WebhookUrl { get; set; }

        /// <inheritdoc />
        public bool? InstanceStatuses { get; set; }

        /// <inheritdoc />
        public bool? WebhookStatuses { get; set; }

        /// <inheritdoc />
        public bool? StatusNotificationsOn { get; set; }

        /// <inheritdoc />
        public bool? AckNotificationsOn { get; set; }

        /// <inheritdoc />
        public bool? ChatUpdateOn { get; set; }

        /// <inheritdoc />
        public bool? VideoUploadOn { get; set; }

        /// <inheritdoc />
        public string? Proxy { get; set; }

        /// <inheritdoc />
        public bool? GuaranteedHooks { get; set; }

        /// <inheritdoc />
        public bool? IgnoreOldMessages { get; set; }

        /// <inheritdoc />
        public int? OldMessagesPeriod { get; set; }

        /// <inheritdoc />
        public bool? ProcessArchive { get; set; }

        /// <inheritdoc />
        public bool? DisableDialogsArchive { get; set; }

        /// <inheritdoc />
        public bool? ParallelHooks { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
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

        #endregion

    }
}
