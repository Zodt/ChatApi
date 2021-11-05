using ChatApi.WA.Account.Models;
using ChatApi.WA.Account.Models.Interfaces;
using ChatApi.WA.Account.Responses.Interfaces;

namespace ChatApi.WA.Account.Responses
{
    /// <summary/>
    public sealed record AccountStatusResponse : IAccountStatusResponse
    {

        #region Properties

        /// <inheritdoc />
        public string? QrCode { get; set; }

        /// <inheritdoc />
        public AccountStatusType? AccountStatus { get; set; }

        /// <inheritdoc />
        public IAccountStatusData? StatusData { get; set; }


        /// <inheritdoc />
        public bool? Success { get; set; }

        /// <inheritdoc />
        public string? Result { get; set; }

        /// <inheritdoc />
        public string? ErrorMessage { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(IAccountStatusResponse? other)
        {
            return other is not null &&
                   AccountStatus == other.AccountStatus &&
                   ErrorMessage == other.ErrorMessage &&
                   QrCode == other.QrCode &&
                   Result == other.Result &&
                   Success == other.Success &&
                   Equals(StatusData, other.StatusData);
        }

        #endregion

    }
}
