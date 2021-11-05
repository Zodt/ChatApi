using ChatApi.Core.Helpers;
using ChatApi.WA.Messages.Collections;
using ChatApi.WA.Messages.Requests.Interfaces;

namespace ChatApi.WA.Messages.Requests
{
    /// <summary/>
    public sealed class LinkMessageRequest : ILinkMessageRequest
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

        /// <inheritdoc />
        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is ILinkMessageRequest self && Equals(self);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = ChatId != null ? ChatId.GetHashCode() : 0;
                hashCode = (hashCode * 397) ^ (Phone != null ? Phone.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (QuotedMessageId != null ? QuotedMessageId.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Body != null ? Body.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (PreviewBase64 != null ? PreviewBase64.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Title != null ? Title.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Description != null ? Description.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (MentionedPhones != null ? MentionedPhones.GetHashCode() : 0);
                return hashCode;
            }
        }

        /// <summary/>
        public static bool operator ==(LinkMessageRequest? left, LinkMessageRequest? right) => EquatableHelper.IsEquatable(left, right);
        /// <summary/>
        public static bool operator !=(LinkMessageRequest? left, LinkMessageRequest? right) => !EquatableHelper.IsEquatable(left, right);

        #endregion

    }
}
