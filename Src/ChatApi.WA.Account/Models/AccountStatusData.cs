using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Account.Models.Interfaces;
using ChatApi.WA.Account.Responses.Interfaces;

namespace ChatApi.WA.Account.Models
{
    public sealed class AccountStatusData : IAccountStatusData
    {
        #region Properties

        public string? Title { get; set; }
        public string? Message { get; set; }
        public string? SubMessage { get; set; }
        public InstanceStatusType? SubStatus { get; set; }
        public IAdditionInformationStatus? Actions { get; set; }
        public InstanceConnectionStatusType? Reason { get; set; }

        #endregion

        #region Equatable

        public bool Equals(IAccountStatusData other)
        {
            return Title == other.Title &&
                   Reason == other.Reason &&
                   Message == other.Message &&
                   SubStatus == other.SubStatus &&
                   SubMessage == other.SubMessage &&
                   Actions == other.Actions;
        }

        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is IAccountStatusData other && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = Title != null ? Title.GetHashCode() : 0;
                hashCode = (hashCode * 397) ^ (Message != null ? Message.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (SubStatus != null ? SubStatus.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (SubMessage != null ? SubMessage.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Actions != null ? Actions.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Reason != null ? Reason.GetHashCode() : 0);
                return hashCode;
            }
        }

        public static bool operator == (AccountStatusData? left, AccountStatusData? right) => EquatableHelper.IsEquatable(left, right);
        public static bool operator != (AccountStatusData? left, AccountStatusData? right) => !EquatableHelper.IsEquatable(left, right);
        
        #endregion
    }
}