using ChatApi.WA.Ban.Models.Interfaces;

namespace ChatApi.WA.Ban.Models
{
    /// <inheritdoc cref="ChatApi.WA.Ban.Models.Interfaces.IBanSettings" />
    public abstract record BanSettings : IBanSettings
    {

        #region Properties

        /// <inheritdoc />
        public bool? IsSet { get; set; }

        /// <inheritdoc />
        public string? BanPhoneMask { get; set; }

        /// <inheritdoc />
        public string? PreBanMessage { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(IBanSettings? other)
        {
            return other is not null &&
                   IsSet == other.IsSet &&
                   BanPhoneMask == other.BanPhoneMask &&
                   PreBanMessage == other.PreBanMessage;
        }

        #endregion

    }
}
