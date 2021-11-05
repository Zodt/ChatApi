using System;
using ChatApi.Core.Helpers;
using ChatApi.WA.Messages.Collections;
using ChatApi.WA.Messages.Requests.Interfaces;

namespace ChatApi.WA.Messages.Requests
{
    /// <summary/>
    public sealed record ContactMessageRequest : IContactMessageRequest
    {

        #region Properties

        /// <inheritdoc />
        public string? Phone { get; set; }

        /// <inheritdoc />
        public string? ChatId { get; set; }

        /// <inheritdoc />
        public string? QuotedMessageId { get; set; }

        /// <inheritdoc />
        public ContactCollection? ContactId { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(IContactMessageRequest? other)
        {
            return other is not null && ContactId == other.ContactId &&
                   string.Equals(Phone, other.Phone, StringComparison.Ordinal) &&
                   string.Equals(ChatId, other.ChatId, StringComparison.Ordinal) &&
                   string.Equals(QuotedMessageId, other.QuotedMessageId, StringComparison.Ordinal);
        }

        #endregion

    }
}
