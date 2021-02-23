using ChatApi.Core.Helpers;
using ChatApi.WA.Account.Responses.Interfaces;

namespace ChatApi.WA.Account.Responses
{ /* ReSharper disable once InconsistentNaming */
    public sealed class OutputIPAddressResponse : IOutputIPAddressResponse
    {
        #region Properties

        public string? Address { get; set; }
        public string? ErrorMessage { get; set; }

        #endregion

        #region Equatable

        public bool Equals(IOutputIPAddressResponse? other)
        {
            return other is not null && ErrorMessage == other.ErrorMessage && Address == other.Address;
        }

        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is IOutputIPAddressResponse other && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((string.IsNullOrWhiteSpace(ErrorMessage) ? 0 : ErrorMessage!.GetHashCode()) * 397) ^
                       (string.IsNullOrWhiteSpace(Address) ? 0 : Address!.GetHashCode());
            }
        }

        public static bool operator == (OutputIPAddressResponse? left, OutputIPAddressResponse? right) => EquatableHelper.IsEquatable(left, right);
        public static bool operator != (OutputIPAddressResponse? left, OutputIPAddressResponse? right) => !EquatableHelper.IsEquatable(left, right);
        
        #endregion
    }
}