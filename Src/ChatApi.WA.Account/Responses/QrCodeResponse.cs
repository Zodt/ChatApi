using ChatApi.WA.Account.Responses.Interfaces;

namespace ChatApi.WA.Account.Responses
{
    /// <inheritdoc cref="ChatApi.WA.Account.Responses.Interfaces.IQrCodeResponse" />
    public sealed record QrCodeResponse : IQrCodeResponse
    {

        #region Properties

        /// <inheritdoc />
        public string? QrCodeImage { get; set; }

        /// <inheritdoc />
        public string? ErrorMessage { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(IQrCodeResponse? other)
        {
            return other is not null && ErrorMessage == other.ErrorMessage && QrCodeImage == other.QrCodeImage;
        }

        #endregion

    }
}
