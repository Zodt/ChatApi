using System;
using ChatApi.Core.Helpers;
using ChatApi.WA.Messages.Collections;
using ChatApi.WA.Messages.Responses.Interfaces;

namespace ChatApi.WA.Messages.Responses
{
    public sealed class MessagesHistoryResponse : IMessagesHistoryResponse
    {
        #region Properties

        public int? Page { get; set; }
        public string? ErrorMessage { get; set; }
        public MessageCollection? Messages { get; set; }

        #endregion

        #region Equatable

        public bool Equals(IMessagesHistoryResponse? other)
        {
            return other is not null && Messages == other.Messages && Page == other.Page &&
                string.Equals(ErrorMessage, other.ErrorMessage, StringComparison.Ordinal);
        }

        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is IMessagesHistoryResponse other && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = Messages != null ? Messages.GetHashCode() : 0;
                hashCode = (hashCode * 397) ^ Page.GetHashCode();
                hashCode = (hashCode * 397) ^ (ErrorMessage != null ? ErrorMessage.GetHashCode() : 0);
                return hashCode;
            }
        }

        public static bool operator ==(MessagesHistoryResponse? left, MessagesHistoryResponse? right) => EquatableHelper.IsEquatable(left, right);
        public static bool operator !=(MessagesHistoryResponse? left, MessagesHistoryResponse? right) => !EquatableHelper.IsEquatable(left, right);

        #endregion
    }
}