using ChatApi.WA.Account.Models.Interfaces;

namespace ChatApi.WA.Account.Models
{
    /// <summary/>
    public sealed record DeviceCharacteristic : IDeviceCharacteristic
    {

        #region Properties

        /// <inheritdoc />
        public string? Model { get; set; }

        /// <inheritdoc />
        public string? OsVersion { get; set; }

        /// <inheritdoc />
        public string? Manufacturer { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(IDeviceCharacteristic? other)
        {
            return other is not null &&
                   OsVersion == other.OsVersion &&
                   Manufacturer == other.Manufacturer &&
                   Model == other.Model;
        }

        #endregion

    }
}
