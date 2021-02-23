using ChatApi.Core.Helpers;
using ChatApi.WA.Account.Models.Interfaces;
using ChatApi.WA.Account.Responses.Interfaces;

namespace ChatApi.WA.Account.Responses
{
    public sealed class AdditionInformationStatus : IAdditionInformationStatus
    {
        #region Properties

        public IInstanceStatus? Expiry { get; set; }
        public IInstanceStatus? Retry { get; set; }
        public IInstanceStatus? Logout { get; set; }
        public IInstanceStatus? Takeover { get; set; }
        public IInstanceStatus? LearnMore { get; set; }

        #endregion
        
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
    }
}