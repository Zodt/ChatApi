using ChatApi.Core.Helpers;
using ChatApi.WA.Ban.Requests.Interfaces;

namespace ChatApi.WA.Ban.Requests
{
    /// <inheritdoc />
    public class CheckBanRequest : ICheckBanRequest
    {

        #region Properties

        /// <inheritdoc />
        public string? Phone { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(ICheckBanRequest? other)
        {
            return other is not null &&
                   Phone == other.Phone;
        }

        /// <inheritdoc />
        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is ICheckBanRequest self && Equals(self);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            return Phone != null ? Phone.GetHashCode() : 0;
        }

        /// <summary/>
        public static bool operator ==(CheckBanRequest? left, CheckBanRequest? right)
        {
            return EquatableHelper.IsEquatable(left, right);
        }
        /// <summary/>
        public static bool operator !=(CheckBanRequest? left, CheckBanRequest? right)
        {
            return !EquatableHelper.IsEquatable(left, right);
        }

        #endregion

    }
}
