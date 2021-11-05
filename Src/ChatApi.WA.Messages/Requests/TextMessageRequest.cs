using System;
using ChatApi.Core.Helpers;
using ChatApi.WA.Messages.Collections;
using ChatApi.WA.Messages.Requests.Interfaces;

namespace ChatApi.WA.Messages.Requests
{
    /// <summary/>
    public sealed record TextMessageRequest : ITextMessageRequest
    {

        #region Properties

        /// <inheritdoc />
        public string? Body { get; set; }

        /// <inheritdoc />
        public string? Phone { get; set; }

        /// <inheritdoc />
        public string? ChatId { get; set; }

        /// <inheritdoc />
        public string? QuotedMessageId { get; set; }

        /// <inheritdoc />
        public MentionedPhonesCollection? MentionedPhones { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(ITextMessageRequest? other)
        {
            return other is not null && MentionedPhones == other.MentionedPhones &&
                   string.Equals(ChatId, other.ChatId, StringComparison.Ordinal) &&
                   string.Equals(Phone, other.Phone, StringComparison.Ordinal) &&
                   string.Equals(Body, other.Body, StringComparison.Ordinal) &&
                   string.Equals(QuotedMessageId, other.QuotedMessageId, StringComparison.Ordinal);
        }

        #endregion

    }
}
