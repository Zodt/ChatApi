using ChatApi.WA.Account.Models.Interfaces;
using ChatApi.WA.Account.Responses.Interfaces;

namespace ChatApi.WA.Account.Responses
{
    /// <summary/>
    public sealed record AccountInformationResponse : IAccountInformationResponse
    {

        #region Properties

        /// <inheritdoc />
        public string? Id { get; set; }

        /// <inheritdoc />
        public string? Battery { get; set; }

        /// <inheritdoc />
        public string? Locale { get; set; }

        /// <inheritdoc />
        public string? Name { get; set; }

        /// <inheritdoc />
        public string? WhatsAppVersion { get; set; }

        /// <inheritdoc />
        public IDeviceCharacteristic? Device { get; set; }

        /// <inheritdoc />
        public string? ErrorMessage { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(IAccountInformationResponse? other)
        {
            return other is not null &&
                   ErrorMessage == other.ErrorMessage &&
                   Id == other.Id && Battery == other.Battery &&
                   Locale == other.Locale &&
                   Name == other.Name &&
                   WhatsAppVersion == other.WhatsAppVersion &&
                   Device == other.Device;
        }

        #endregion

    }
}
