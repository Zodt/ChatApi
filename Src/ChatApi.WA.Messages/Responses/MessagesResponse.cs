using System;

using ChatApi.Core.Helpers;
using ChatApi.Core.Models;

using ChatApi.WA.Messages.Collections;
using ChatApi.WA.Messages.Responses.Interfaces;

namespace ChatApi.WA.Messages.Responses
{
    public sealed class MessagesResponse : Printable, IMessagesResponse
    {
        #region Properties

        public string? ErrorMessage { get; set; }
        public int? LastMessageNumber { get; set; }
        public MessageCollection? Messages { get; set; }

        #endregion

        #region Equatable

        public bool Equals(IMessagesResponse? other)
        {
            return other is not null &&
                   LastMessageNumber == other.LastMessageNumber && Messages == other.Messages &&
                   string.Equals(ErrorMessage, other.ErrorMessage, StringComparison.Ordinal);
        }

        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is IMessagesResponse other && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = LastMessageNumber.GetHashCode();
                hashCode = (hashCode * 397) ^ (Messages is not null ? Messages.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (ErrorMessage is not null ? ErrorMessage.GetHashCode() : 0);
                return hashCode;
            }
        }

        public static bool operator ==(MessagesResponse? left, MessagesResponse? right) => EquatableHelper.IsEquatable(left, right);
        public static bool operator !=(MessagesResponse? left, MessagesResponse? right) => !EquatableHelper.IsEquatable(left, right);

        #endregion

        #region Printable

        protected override void PrintContent(int shift)
        {
            AddMember(nameof(LastMessageNumber), LastMessageNumber, shift);
            AddMember(nameof(Messages), Messages?.PrintMembers(shift + 1), shift);
            AddMember(nameof(ErrorMessage), ErrorMessage, shift);
        }

        #endregion
    }
}