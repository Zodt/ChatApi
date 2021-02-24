using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Account.Models.Interfaces;
using ChatApi.WA.Account.Responses.Interfaces;

namespace ChatApi.WA.Account.Responses
{
    public sealed class AdditionInformationStatus : Printable, IAdditionInformationStatus
    {
        #region Properties

        public IInstanceStatus? Retry { get; set; }
        public IInstanceStatus? Expiry { get; set; }
        public IInstanceStatus? Logout { get; set; }
        public IInstanceStatus? Takeover { get; set; }
        public IInstanceStatus? LearnMore { get; set; }

        #endregion

        #region Equatable

        public bool Equals(IAdditionInformationStatus? other)
        {
            return other is not null &&
                   Retry == other.Retry &&
                   Expiry == other.Expiry &&
                   Logout == other.Logout &&
                   Takeover == other.Takeover &&
                   LearnMore == other.LearnMore;
        }

        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is IAdditionInformationStatus other && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = Expiry != null ? Expiry.GetHashCode() : 0;
                hashCode = (hashCode * 397) ^ (Retry != null ? Retry.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Logout != null ? Logout.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Takeover != null ? Takeover.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (LearnMore != null ? LearnMore.GetHashCode() : 0);
                return hashCode;
            }
        }

        public static bool operator == (AdditionInformationStatus? left, AdditionInformationStatus? right) => EquatableHelper.IsEquatable(left, right);
        public static bool operator != (AdditionInformationStatus? left, AdditionInformationStatus? right) => !EquatableHelper.IsEquatable(left, right);

        #endregion

        #region Printable

        protected override void PrintContent(int shift)
        {
            AddMember(nameof(Retry), Retry, shift);
            AddMember(nameof(Expiry), Expiry, shift);
            AddMember(nameof(Logout), Logout, shift);
            AddMember(nameof(Takeover), Takeover, shift);
            AddMember(nameof(LearnMore), LearnMore, shift);
        }

        #endregion
    }
}