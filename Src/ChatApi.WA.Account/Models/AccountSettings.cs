using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Account.Models.Interfaces;

namespace ChatApi.WA.Account.Models
{
    public class AccountSettings : Printable, IAccountSettings
    {
        #region Properties

        public string? ErrorMessage { get; set; }
        public int? SendDelay { get; set; }
        public string? WebhookUrl { get; set; }
        public bool? InstanceStatuses { get; set; }
        public bool? WebhookStatuses { get; set; }
        public bool? StatusNotificationsOn { get; set; }
        public bool? AckNotificationsOn { get; set; }
        public bool? ChatUpdateOn { get; set; }
        public bool? VideoUploadOn { get; set; }
        public string? Proxy { get; set; }
        public bool? GuaranteedHooks { get; set; }
        public bool? IgnoreOldMessages { get; set; }
        public int? OldMessagesPeriod { get; set; }
        public bool? ProcessArchive { get; set; }
        public bool? DisableDialogsArchive { get; set; }
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
        
        #region Printable

        protected override void PrintContent(int shift)
        {
            AddMember(nameof(SendDelay), SendDelay, shift);
            AddMember(nameof(WebhookUrl), WebhookUrl, shift);
            AddMember(nameof(InstanceStatuses), InstanceStatuses, shift);
            AddMember(nameof(WebhookStatuses), WebhookStatuses, shift);
            AddMember(nameof(StatusNotificationsOn), StatusNotificationsOn, shift);
            AddMember(nameof(AckNotificationsOn), AckNotificationsOn, shift);
            AddMember(nameof(ChatUpdateOn), ChatUpdateOn, shift);
            AddMember(nameof(VideoUploadOn), VideoUploadOn, shift);
            AddMember(nameof(Proxy), Proxy, shift);
            AddMember(nameof(GuaranteedHooks), GuaranteedHooks, shift);
            AddMember(nameof(IgnoreOldMessages), IgnoreOldMessages, shift);
            AddMember(nameof(OldMessagesPeriod), OldMessagesPeriod, shift);
            AddMember(nameof(ProcessArchive), ProcessArchive, shift);
            AddMember(nameof(DisableDialogsArchive), DisableDialogsArchive, shift);
            AddMember(nameof(ParallelHooks), ParallelHooks, shift);
            AddMember(nameof(ErrorMessage), ErrorMessage, shift);
        }

        #endregion
    }
}