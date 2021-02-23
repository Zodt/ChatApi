using System;
using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Dialogs.Responses.UI.Interfaces;

namespace ChatApi.WA.Dialogs.Responses.UI
{
    public abstract class ChatOperationResponse : Printable, IChatOperationResponse
    {
        #region Properties

        public string? ChatId { get; set; }
        public ChatApiStatusOperation? Result { get; set; }
        public string? ErrorMessage { get; set; }

        #endregion

        #region Equatable

        public bool Equals(IChatOperationResponse? other)
        {
            return other is not null && Result == other.Result && 
                   string.Equals(ChatId, other.ChatId, StringComparison.Ordinal) &&
                   string.Equals(ErrorMessage, other.ErrorMessage, StringComparison.Ordinal);
        }

        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is IChatOperationResponse other && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = ChatId is null ? 0 : ChatId.GetHashCode();
                hashCode = (hashCode * 397) ^ (Result is null ? 0 : Result.GetHashCode());
                hashCode = (hashCode * 397) ^ (ErrorMessage is null ? 0 : ErrorMessage.GetHashCode());
                return hashCode;
            }
        }

        public static bool operator == (ChatOperationResponse? left, ChatOperationResponse? right) => EquatableHelper.IsEquatable(left, right);
        public static bool operator != (ChatOperationResponse? left, ChatOperationResponse? right) => !EquatableHelper.IsEquatable(left, right);

        #endregion

        #region Printable

        protected override void PrintContent(int shift)
        {
            AddMember(nameof(ChatId), ChatId, shift);
            AddMember(nameof(Result), Result, shift);
            AddMember(nameof(ErrorMessage), ErrorMessage, shift);
        }

        #endregion
    }
}