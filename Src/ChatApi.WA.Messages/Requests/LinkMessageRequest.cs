using ChatApi.WA.Messages.Collections;
using ChatApi.WA.Messages.Requests.Interfaces;

namespace ChatApi.WA.Messages.Requests
{
    /// <summary/>
    public sealed record LinkMessageRequest : ILinkMessageRequest
    {

        #region Properties

        /// <inheritdoc />
        public string? Body { get; set; }

        /// <inheritdoc />
        public string? Title { get; set; }

        /// <inheritdoc />
        public string? Phone { get; set; }

        /// <inheritdoc />
        public string? ChatId { get; set; }

        /// <inheritdoc />
        public string? Description { get; set; }

        /// <inheritdoc />
        public string? PreviewBase64 { get; set; }

        /// <inheritdoc />
        public string? QuotedMessageId { get; set; }

        /// <inheritdoc />
        public MentionedPhonesCollection? MentionedPhones { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(ILinkMessageRequest? other)
        {
            return other is not null &&
                   MentionedPhones == other.MentionedPhones &&
                   ChatId == other.ChatId &&
                   Phone == other.Phone &&
                   QuotedMessageId == other.QuotedMessageId &&
                   Body == other.Body &&
                   PreviewBase64 == other.PreviewBase64 &&
                   Title == other.Title &&
                   Description == other.Description;
        }

        #endregion

    }
}
