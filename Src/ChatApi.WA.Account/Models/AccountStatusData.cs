using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Account.Models.Interfaces;
using ChatApi.WA.Account.Responses.Interfaces;

namespace ChatApi.WA.Account.Models
{
    /// <summary/>
    public sealed class AccountStatusData : Printable, IAccountStatusData
    {

        #region Properties

        /// <inheritdoc />
        public string? Title { get; set; }

        /// <inheritdoc />
        public string? Message { get; set; }

        /// <inheritdoc />
        public string? SubMessage { get; set; }

        /// <inheritdoc />
        public InstanceStatusType? SubStatus { get; set; }

        /// <inheritdoc />
        public IAdditionInformationStatus? Actions { get; set; }

        /// <inheritdoc />
        public InstanceConnectionStatusType? Reason { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(IAccountStatusData other)
        {
            return Title == other.Title &&
                   Reason == other.Reason &&
                   Message == other.Message &&
                   SubStatus == other.SubStatus &&
                   SubMessage == other.SubMessage &&
                   Actions == other.Actions;
        }

        /// <inheritdoc />
        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is IAccountStatusData other && Equals(other);
        }

        /// <inheritdoc />
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

        /// <summary/>
        public static bool operator ==(AccountStatusData? left, AccountStatusData? right)
        {
            return EquatableHelper.IsEquatable(left, right);
        }
        /// <summary/>
        public static bool operator !=(AccountStatusData? left, AccountStatusData? right)
        {
            return !EquatableHelper.IsEquatable(left, right);
        }

        #endregion

        #region Printable

        /// <inheritdoc />
        protected override void PrintContent(int shift)
        {
            AddMember(nameof(Title), Title, shift);
            AddMember(nameof(Message), Message, shift);
            AddMember(nameof(SubMessage), SubMessage, shift);
            AddMember(nameof(SubStatus), SubStatus, shift);
            AddMember(nameof(Actions), Actions, shift);
            AddMember(nameof(Reason), Reason, shift);
        }

        #endregion

    }
}
