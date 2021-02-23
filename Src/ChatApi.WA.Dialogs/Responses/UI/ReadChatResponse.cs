using System;

using ChatApi.Core.Models;
using ChatApi.Core.Helpers;
using ChatApi.WA.Dialogs.Responses.UI.Interfaces;

namespace ChatApi.WA.Dialogs.Responses.UI
{
    public sealed class ReadChatResponse : Printable, IReadChatResponse
    {
        #region Properties

        public bool? Read { get; set; }
        public string? ChatId { get; set; }
        public string? Message { get; set; }
        public string? ErrorMessage { get; set; }

        #endregion

        #region Equatable

        public bool Equals(IReadChatResponse? other)
        {
            return other is not null && Read == other.Read &&
                   string.Equals(ChatId, other.ChatId, StringComparison.Ordinal) &&
                   string.Equals(Message, other.Message, StringComparison.Ordinal) &&
                   string.Equals(ErrorMessage, other.ErrorMessage, StringComparison.Ordinal);
        }

        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is IReadChatResponse other && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = Read.GetHashCode();
                hashCode = (hashCode * 397) ^ (ChatId is null ? 0 : ChatId.GetHashCode());
                hashCode = (hashCode * 397) ^ (Message is null? 0 : Message.GetHashCode());
                hashCode = (hashCode * 397) ^ (ErrorMessage is null? 0 : ErrorMessage.GetHashCode());
                return hashCode;
            }
        }

        public static bool operator == (ReadChatResponse? left, ReadChatResponse? right) => EquatableHelper.IsEquatable(left, right);
        public static bool operator != (ReadChatResponse? left, ReadChatResponse? right) => !EquatableHelper.IsEquatable(left, right);

        #endregion

        #region Printable

        protected override void PrintContent(int shift)
        {
            AddMember(nameof(Read), Read, shift);
            AddMember(nameof(ChatId), ChatId, shift);
            AddMember(nameof(Message), Message, shift);
            AddMember(nameof(ErrorMessage), ErrorMessage, shift);
        }        

        #endregion

    }
}