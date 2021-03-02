using System;
using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Messages.Collections;
using ChatApi.WA.Messages.Responses.Interfaces;

namespace ChatApi.WA.Messages.Responses
{
    /// <inheritdoc cref="ChatApi.WA.Messages.Responses.Interfaces.IMessagesHistoryResponse" />
    public sealed class MessagesHistoryResponse : Printable, IMessagesHistoryResponse
    {
        #region Properties

        /// <inheritdoc />
        public int? Page { get; set; }
        
        /// <inheritdoc />
        public string? ErrorMessage { get; set; }
        
        /// <inheritdoc />
        public MessageCollection? Messages { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(IMessagesHistoryResponse? other)
        {
            return other is not null && Messages == other.Messages && Page == other.Page &&
                string.Equals(ErrorMessage, other.ErrorMessage, StringComparison.Ordinal);
        }

        /// <inheritdoc />
        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is IMessagesHistoryResponse other && Equals(other);
        }

        /// <inheritdoc />
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

        /// <summary/>
        public static bool operator ==(MessagesHistoryResponse? left, MessagesHistoryResponse? right) => EquatableHelper.IsEquatable(left, right);
        /// <summary/>
        public static bool operator !=(MessagesHistoryResponse? left, MessagesHistoryResponse? right) => !EquatableHelper.IsEquatable(left, right);

        #endregion

        #region Printable

        /// <inheritdoc />
        protected override void PrintContent(int shift)
        {
            AddMember(nameof(Page), Page, shift);
            AddMember(nameof(Messages), Messages?.PrintMembers(shift + 1), shift);
            AddMember(nameof(ErrorMessage), ErrorMessage, shift);
        }

        #endregion
    }
}