using ChatApi.WA.Messages.Requests.Interfaces;

namespace ChatApi.WA.Messages.Requests
{
    /// <summary/>
    public sealed record VoiceMessageRequest : IVoiceMessageRequest
    {

        #region Properties

        /// <inheritdoc />
        public string? ChatId { get; set; }

        /// <inheritdoc />
        public string? Phone { get; set; }

        /// <inheritdoc />
        public string? QuotedMessageId { get; set; }

        /// <inheritdoc />
        public string? Audio { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(IVoiceMessageRequest? other)
        {
            return other is not null &&
                   ChatId == other.ChatId &&
                   Phone == other.Phone &&
                   QuotedMessageId == other.QuotedMessageId &&
                   Audio == other.Audio;
        }

        #endregion

    }
}
