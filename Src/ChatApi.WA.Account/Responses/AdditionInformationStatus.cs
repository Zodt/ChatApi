using ChatApi.WA.Account.Models.Interfaces;
using ChatApi.WA.Account.Responses.Interfaces;

namespace ChatApi.WA.Account.Responses
{
    /// <inheritdoc cref="ChatApi.WA.Account.Responses.Interfaces.IAdditionInformationStatus" />
    public sealed record AdditionInformationStatus : IAdditionInformationStatus
    {

        #region Properties

        /// <inheritdoc />
        public IInstanceStatus? Retry { get; set; }

        /// <inheritdoc />
        public IInstanceStatus? Expiry { get; set; }

        /// <inheritdoc />
        public IInstanceStatus? Logout { get; set; }

        /// <inheritdoc />
        public IInstanceStatus? Takeover { get; set; }

        /// <inheritdoc />
        public IInstanceStatus? LearnMore { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(IAdditionInformationStatus? other)
        {
            return other is not null &&
                   Retry == other.Retry &&
                   Expiry == other.Expiry &&
                   Logout == other.Logout &&
                   Takeover == other.Takeover &&
                   LearnMore == other.LearnMore;
        }

        #endregion

    }
}
