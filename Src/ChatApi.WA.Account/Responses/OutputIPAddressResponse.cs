using ChatApi.WA.Account.Responses.Interfaces;

/* ReSharper disable once InconsistentNaming */
namespace ChatApi.WA.Account.Responses
{
    /// <summary/>
    public sealed record OutputIPAddressResponse : IOutputIPAddressResponse
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

        #endregion

    }
}
