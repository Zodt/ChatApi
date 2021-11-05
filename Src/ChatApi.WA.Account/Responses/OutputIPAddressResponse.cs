using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Account.Responses.Interfaces;

namespace ChatApi.WA.Account.Responses
{/* ReSharper disable once InconsistentNaming */
    /// <summary/>
    public sealed class OutputIPAddressResponse : Printable, IOutputIPAddressResponse
    {

        #region Properties

        /// <inheritdoc />
        public string? Address { get; set; }

        /// <inheritdoc />
        public string? ErrorMessage { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(IOutputIPAddressResponse? other)
        {
            return other is not null && ErrorMessage == other.ErrorMessage && Address == other.Address;
        }

        /// <inheritdoc />
        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is IOutputIPAddressResponse other && Equals(other);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked
            {
                return ((string.IsNullOrWhiteSpace(ErrorMessage) ? 0 : ErrorMessage!.GetHashCode()) * 397) ^
                       (string.IsNullOrWhiteSpace(Address) ? 0 : Address!.GetHashCode());
            }
        }

        /// <summary/>
        public static bool operator ==(OutputIPAddressResponse? left, OutputIPAddressResponse? right)
        {
            return EquatableHelper.IsEquatable(left, right);
        }
        /// <summary/>
        public static bool operator !=(OutputIPAddressResponse? left, OutputIPAddressResponse? right)
        {
            return !EquatableHelper.IsEquatable(left, right);
        }

        #endregion

        #region Printable

        /// <inheritdoc />
        protected override void PrintContent(int shift)
        {
            AddMember(nameof(Address), Address, shift);
            AddMember(nameof(ErrorMessage), ErrorMessage, shift);
        }

        #endregion

    }
}
