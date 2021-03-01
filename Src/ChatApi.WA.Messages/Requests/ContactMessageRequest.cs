using System;
using ChatApi.Core.Helpers;
using ChatApi.WA.Messages.Collections;
using ChatApi.WA.Messages.Requests.Interfaces;

namespace ChatApi.WA.Messages.Requests
{
    /// <summary/>
    public sealed class ContactMessageRequest : IContactMessageRequest
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

        /// <inheritdoc />
        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is IContactMessageRequest other && Equals(other);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = ChatId != null ? ChatId.GetHashCode() : 0;
                hashCode = (hashCode * 397) ^ (Phone != null ? Phone.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (QuotedMessageId != null ? QuotedMessageId.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (ContactId != null ? ContactId.GetHashCode() : 0);
                return hashCode;
            }
        }

        /// <summary/>
        public static bool operator == (ContactMessageRequest? left, ContactMessageRequest? right) => EquatableHelper.IsEquatable(left, right);
        /// <summary/>
        public static bool operator != (ContactMessageRequest? left, ContactMessageRequest? right) => !EquatableHelper.IsEquatable(left, right);

        #endregion
    }
}