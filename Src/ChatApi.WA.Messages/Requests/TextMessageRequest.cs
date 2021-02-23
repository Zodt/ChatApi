using System;
using ChatApi.Core.Helpers;
using ChatApi.WA.Messages.Collections;
using ChatApi.WA.Messages.Requests.Interfaces;

namespace ChatApi.WA.Messages.Requests
{
    public sealed class TextMessageRequest : ITextMessageRequest
    {
        #region Properties

        public string? Body { get; set; }
        public string? Phone { get; set; }
        public string? ChatId { get; set; }
        public string? QuotedMessageId { get; set; }
        public MentionedPhonesCollection? MentionedPhones { get; set; }
        
        #endregion

        #region Equatable
        
        public bool Equals(ITextMessageRequest? other)
        {
            return other is not null && MentionedPhones == other.MentionedPhones &&
               string.Equals(ChatId, other.ChatId, StringComparison.Ordinal) &&
               string.Equals(Phone, other.Phone, StringComparison.Ordinal) &&
               string.Equals(Body, other.Body, StringComparison.Ordinal) &&
               string.Equals(QuotedMessageId, other.QuotedMessageId, StringComparison.Ordinal);
        }

        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is ITextMessageRequest self && Equals(self);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = ChatId != null ? ChatId.GetHashCode() : 0;
                hashCode = (hashCode * 397) ^ (Phone != null ? Phone.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (QuotedMessageId != null ? QuotedMessageId.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Body != null ? Body.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (MentionedPhones != null ? MentionedPhones.GetHashCode() : 0);
                return hashCode;
            }
        }

        public static bool operator == (TextMessageRequest? left, TextMessageRequest? right) => EquatableHelper.IsEquatable(left, right);
        public static bool operator != (TextMessageRequest? left, TextMessageRequest? right) => !EquatableHelper.IsEquatable(left, right);

        #endregion
    }
}