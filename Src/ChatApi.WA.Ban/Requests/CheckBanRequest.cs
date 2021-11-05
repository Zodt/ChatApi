using ChatApi.WA.Ban.Requests.Interfaces;

namespace ChatApi.WA.Ban.Requests
{
    /// <inheritdoc />
    public sealed record CheckBanRequest : ICheckBanRequest
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

        #endregion

    }
}
