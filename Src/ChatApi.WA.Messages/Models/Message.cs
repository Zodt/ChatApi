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

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(IMessage? other)
        {
            return other is not null &&
                   string.Equals(Id, other.Id, StringComparison.Ordinal) &&
                   string.Equals(Body, other.Body, StringComparison.Ordinal) &&
                   string.Equals(ChatId, other.ChatId, StringComparison.Ordinal) &&
                   string.Equals(Author, other.Author, StringComparison.Ordinal) &&
                   string.Equals(SenderName, other.SenderName, StringComparison.Ordinal) &&
                   string.Equals(QuotedMessageId, other.QuotedMessageId, StringComparison.Ordinal) &&
                   string.Equals(QuotedMessageBody, other.QuotedMessageBody, StringComparison.Ordinal) &&
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

        #endregion

    }
}
