using ChatApi.WA.Account.Models;
using ChatApi.WA.Account.Models.Interfaces;
using ChatApi.WA.Account.Responses.Interfaces;

namespace ChatApi.WA.Account.Responses
{
    /// <inheritdoc cref="ChatApi.WA.Account.Responses.Interfaces.IAccountSettingsResponse" />
    public sealed record AccountSettingsResponse : AccountSettings, IAccountSettingsResponse
    {

        #region Properties

        /// <inheritdoc />
        public IAccountSettings? Update { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(IAccountSettingsResponse? other)
        {
            return other is not null &&
                   base.Equals(other) &&
                   Update == other.Update;
        }

        #endregion

    }
}
