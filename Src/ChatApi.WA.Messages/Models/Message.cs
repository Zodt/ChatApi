using System;
using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Messages.Models.Interfaces;

namespace ChatApi.WA.Messages.Models
{
    public sealed class Message : IMessage
    {
        #region Properties

        public string? ChatId { get; set; }
        public string? Id { get; set; }
        public string? Body { get; set; }
        public MessageType? Type { get; set; }
        public string? SenderName { get; set; }
        public bool? FromMe { get; set; }
        public string? Author { get; set; }
        public DateTime? Time { get; set; }
        public int? MessageNumber { get; set; }
        public int? Self { get; set; }
        public int? IsForwarded { get; set; }
        public string? QuotedMessageBody { get; set; }
        public string? QuotedMessageId { get; set; }
        public MessageType? QuotedMessageType { get; set; }
        public string? ChatName { get; set; }

        #endregion

        #region Equatable

        public bool Equals(IMessage? other)
        {
            return other is not null &&
                   string.Equals(Id, other.Id,StringComparison.Ordinal) &&
                   string.Equals(Body, other.Body,StringComparison.Ordinal) &&
                   string.Equals(ChatId, other.ChatId,StringComparison.Ordinal) &&
                   string.Equals(Author, other.Author,StringComparison.Ordinal) &&
                   string.Equals(SenderName, other.SenderName,StringComparison.Ordinal) &&
                   string.Equals(QuotedMessageId, other.QuotedMessageId,StringComparison.Ordinal) &&
                   string.Equals(QuotedMessageBody, other.QuotedMessageBody,StringComparison.Ordinal) &&

                   Type == other.Type && 
                   FromMe == other.FromMe && 
                   Time == other.Time && 
                   MessageNumber == other.MessageNumber && 
                   Self == other.Self && 
                   IsForwarded == other.IsForwarded && 
                   QuotedMessageId == other.QuotedMessageId && 
                   QuotedMessageType == other.QuotedMessageType && 
                   ChatName == other.ChatName;
        }

        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj is IMessage message && Equals(message);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = ChatId != null ? ChatId.GetHashCode() : 0;
                hashCode = (hashCode * 397) ^ (Id != null ? Id.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Body != null ? Body.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Type != null ? Type.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (SenderName != null ? SenderName.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ FromMe.GetHashCode();
                hashCode = (hashCode * 397) ^ (Author != null ? Author.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ Time.GetHashCode();
                hashCode = (hashCode * 397) ^ MessageNumber.GetHashCode();
                hashCode = (hashCode * 397) ^ Self.GetHashCode();
                hashCode = (hashCode * 397) ^ IsForwarded.GetHashCode();
                hashCode = (hashCode * 397) ^ (QuotedMessageBody != null ? QuotedMessageBody.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (QuotedMessageId != null ? QuotedMessageId.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (QuotedMessageType != null ? QuotedMessageType.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (ChatName != null ? ChatName.GetHashCode() : 0);
                return hashCode;
            }
        }

        public static bool operator == (Message? left, Message? right) => EquatableHelper.IsEquatable(left, right);
        public static bool operator != (Message? left, Message? right) => !EquatableHelper.IsEquatable(left, right); 

        #endregion
    }
}