using System;
using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Messages.Models.Interfaces;

namespace ChatApi.WA.Messages.Models
{
    /// <inheritdoc cref="ChatApi.WA.Messages.Models.Interfaces.IMessage" />
    public sealed class Message : Printable, IMessage
    {
        #region Properties

        /// <inheritdoc />
        public string? ChatId { get; set; }
        /// <inheritdoc />
        public string? Id { get; set; }
        /// <inheritdoc />
        public string? Body { get; set; }
        /// <inheritdoc />
        public MessageType? Type { get; set; }
        /// <inheritdoc />
        public string? SenderName { get; set; }
        /// <inheritdoc />
        public bool? FromMe { get; set; }
        /// <inheritdoc />
        public string? Author { get; set; }
        /// <inheritdoc />
        public DateTime? Time { get; set; }
        /// <inheritdoc />
        public int? MessageNumber { get; set; }
        /// <inheritdoc />
        public int? Self { get; set; }
        /// <inheritdoc />
        public int? IsForwarded { get; set; }
        /// <inheritdoc />
        public string? QuotedMessageBody { get; set; }
        /// <inheritdoc />
        public string? QuotedMessageId { get; set; }
        /// <inheritdoc />
        public MessageType? QuotedMessageType { get; set; }
        /// <inheritdoc />
        public string? ChatName { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
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

        /// <inheritdoc />
        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj is IMessage message && Equals(message);
        }

        /// <inheritdoc />
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

        /// <summary/>
        public static bool operator == (Message? left, Message? right) => EquatableHelper.IsEquatable(left, right);
        /// <summary/>
        public static bool operator != (Message? left, Message? right) => !EquatableHelper.IsEquatable(left, right); 

        #endregion

        #region Printable

        /// <inheritdoc />
        protected override void PrintContent(int shift)
        {
            AddMember(nameof(Id), Id, shift);
            AddMember(nameof(ChatId), ChatId, shift);
            AddMember(nameof(ChatName), ChatName, shift);
            AddMember(nameof(Time), Time, shift);
            AddMember(nameof(Type), Type, shift);
            AddMember(nameof(Body), Body, shift);
            AddMember(nameof(Self), Self, shift);
            AddMember(nameof(FromMe), FromMe, shift);
            AddMember(nameof(Author), Author, shift);
            AddMember(nameof(IsForwarded), IsForwarded, shift);
            AddMember(nameof(QuotedMessageBody), QuotedMessageBody, shift);
            AddMember(nameof(QuotedMessageId), QuotedMessageId, shift);
            AddMember(nameof(QuotedMessageType), QuotedMessageType, shift);
            AddMember(nameof(MessageNumber), MessageNumber, shift);
        }

        #endregion
    }
}