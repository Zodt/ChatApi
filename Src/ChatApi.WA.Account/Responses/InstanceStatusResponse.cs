using ChatApi.WA.Account.Models;
using ChatApi.WA.Account.Responses.Interfaces;

namespace ChatApi.WA.Account.Responses
{
    /// <inheritdoc cref="ChatApi.WA.Account.Responses.Interfaces.IInstanceStatusResponse" />
    public record InstanceStatusResponse : InstanceStatus, IInstanceStatusResponse
    {

        #region Properties

        /// <inheritdoc />
        public string? Result { get; set; }

        /// <inheritdoc />
        public bool? Success { get; set; }

        /// <inheritdoc />
        public string? ErrorMessage { get; set; }

        /// <inheritdoc />
        public AccountStatusType? AccountStatus { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(IInstanceStatusResponse? other)
        {
            return base.Equals(other) &&
                   Result == other!.Result &&
                   Success == other.Success &&
                   ErrorMessage == other.ErrorMessage &&
                   AccountStatus == other.AccountStatus;
        }

        #endregion

    }
}
