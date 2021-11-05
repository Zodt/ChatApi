using System;
using ChatApi.Core.Helpers;
using ChatApi.WA.Messages.Collections;
using ChatApi.WA.Messages.Requests.Interfaces;

namespace ChatApi.WA.Messages.Requests
{
    /// <summary/>
    public sealed record FileMessageRequest : IFileMessageRequest
    {

        #region Properties

        /// <inheritdoc />
        public string? Body { get; set; }

        /// <inheritdoc />
        public bool? Cached { get; set; }

        /// <inheritdoc />
        public string? Phone { get; set; }

        /// <inheritdoc />
        public string? ChatId { get; set; }

        /// <inheritdoc />
        public string? Caption { get; set; }

        /// <inheritdoc />
        public string? FileName { get; set; }

        /// <inheritdoc />
        public string? QuotedMessageId { get; set; }

        /// <inheritdoc />
        public MentionedPhonesCollection? MentionedPhones { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(IFileMessageRequest? other)
        {
            return other is not null && Cached == other.Cached &&
                   MentionedPhones == other.MentionedPhones &&
                   string.Equals(ChatId, other.ChatId, StringComparison.Ordinal) &&
                   string.Equals(Phone, other.Phone, StringComparison.Ordinal) &&
                   string.Equals(Body, other.Body, StringComparison.Ordinal) &&
                   string.Equals(FileName, other.FileName, StringComparison.Ordinal) &&
                   string.Equals(Caption, other.Caption, StringComparison.Ordinal) &&
                   string.Equals(QuotedMessageId, other.QuotedMessageId, StringComparison.Ordinal);
        }

        #endregion

    }
}
