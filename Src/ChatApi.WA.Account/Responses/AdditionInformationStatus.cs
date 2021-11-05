using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Account.Models.Interfaces;
using ChatApi.WA.Account.Responses.Interfaces;

namespace ChatApi.WA.Account.Responses
{
    /// <inheritdoc cref="ChatApi.WA.Account.Responses.Interfaces.IAdditionInformationStatus" />
    public sealed class AdditionInformationStatus : Printable, IAdditionInformationStatus
    {

        #region Properties

        /// <inheritdoc />
        public IInstanceStatus? Retry { get; set; }

        /// <inheritdoc />
        public IInstanceStatus? Expiry { get; set; }

        /// <inheritdoc />
        public IInstanceStatus? Logout { get; set; }

        /// <inheritdoc />
        public IInstanceStatus? Takeover { get; set; }

        /// <inheritdoc />
        public IInstanceStatus? LearnMore { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(IAdditionInformationStatus? other)
        {
            return other is not null &&
                   Retry == other.Retry &&
                   Expiry == other.Expiry &&
                   Logout == other.Logout &&
                   Takeover == other.Takeover &&
                   LearnMore == other.LearnMore;
        }

        /// <inheritdoc />
        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is IAdditionInformationStatus other && Equals(other);
        }

        /// <inheritdoc />
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

        /// <summary/>
        public static bool operator ==(AdditionInformationStatus? left, AdditionInformationStatus? right)
        {
            return EquatableHelper.IsEquatable(left, right);
        }
        /// <summary/>
        public static bool operator !=(AdditionInformationStatus? left, AdditionInformationStatus? right)
        {
            return !EquatableHelper.IsEquatable(left, right);
        }

        #endregion

        #region Printable

        /// <inheritdoc />
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
