using System;
using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Messages.Models.Interfaces;

namespace ChatApi.WA.Messages.Models
{
    /// <inheritdoc cref="ChatApi.WA.Messages.Models.Interfaces.IMessage" />
    public sealed record Message : IMessage
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

        public string? Caption { get; set; }

        #endregion


        public bool Equals(IMessage? other) => Equals(other as Message);

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (ChatId != null ? ChatId.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Id != null ? Id.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Body != null ? Body.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ Type.GetHashCode();
                hashCode = (hashCode * 397) ^ (SenderName != null ? SenderName.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ FromMe.GetHashCode();
                hashCode = (hashCode * 397) ^ (Author != null ? Author.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ Time.GetHashCode();
                hashCode = (hashCode * 397) ^ MessageNumber.GetHashCode();
                hashCode = (hashCode * 397) ^ Self.GetHashCode();
                hashCode = (hashCode * 397) ^ IsForwarded.GetHashCode();
                hashCode = (hashCode * 397) ^ (QuotedMessageBody != null ? QuotedMessageBody.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (QuotedMessageId != null ? QuotedMessageId.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ QuotedMessageType.GetHashCode();
                hashCode = (hashCode * 397) ^ (ChatName != null ? ChatName.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Caption != null ? Caption.GetHashCode() : 0);
                return hashCode;
            }
        }
    }
}
