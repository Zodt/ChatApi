using ChatApi.WA.Ban.Responses.Interfaces;

namespace ChatApi.WA.Ban.Responses
{
    /// <inheritdoc cref="ChatApi.WA.Ban.Responses.Interfaces.ICheckBanResponse" />
    public sealed record CheckBanResponse : ICheckBanResponse
    {

        #region Properties

        /// <inheritdoc />
        public string? Phone { get; set; }

        /// <inheritdoc />
        public bool? IsBanned { get; set; }

        /// <inheritdoc />
        public string? Message { get; set; }

        /// <inheritdoc />
        public string? BanPhoneMask { get; set; }

        /// <inheritdoc />
        public string? ErrorMessage { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(ICheckBanResponse? other)
        {
            return other is not null &&
                   ErrorMessage == other.ErrorMessage &&
                   Phone == other.Phone &&
                   IsBanned == other.IsBanned &&
                   Message == other.Message &&
                   BanPhoneMask == other.BanPhoneMask;
        }

        #endregion

    }
}
