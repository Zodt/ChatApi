using ChatApi.WA.Account.Models.Interfaces;
using ChatApi.WA.Account.Responses.Interfaces;

namespace ChatApi.WA.Account.Models
{
    /// <summary/>
    public sealed record AccountStatusData : IAccountStatusData
    {

        #region Properties

        /// <inheritdoc />
        public string? Title { get; set; }

        /// <inheritdoc />
        public string? Message { get; set; }

        /// <inheritdoc />
        public string? SubMessage { get; set; }

        /// <inheritdoc />
        public InstanceStatusType? SubStatus { get; set; }

        /// <inheritdoc />
        public IAdditionInformationStatus? Actions { get; set; }

        /// <inheritdoc />
        public InstanceConnectionStatusType? Reason { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(IAccountStatusData other)
        {
            return Title == other.Title &&
                   Reason == other.Reason &&
                   Message == other.Message &&
                   SubStatus == other.SubStatus &&
                   SubMessage == other.SubMessage &&
                   Actions == other.Actions;
        }

        #endregion

    }
}
