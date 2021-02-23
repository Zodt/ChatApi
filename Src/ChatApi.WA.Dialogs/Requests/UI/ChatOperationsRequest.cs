using System;
using ChatApi.Core.Helpers;
using ChatApi.Core.Models.Interfaces;
using ChatApi.WA.Dialogs.Requests.UI.Interfaces;

namespace ChatApi.WA.Dialogs.Requests.UI
{
    public abstract class ChatOperationsRequest : IChatOperationsRequest
    {
        public string? ChatId { get; set; }
        public string? Phone { get; set; }

        public bool Equals(IMessageRequest? other)
        {
            return other is IChatOperationsRequest chatOperationsRequest &&
                   string.Equals(ChatId, chatOperationsRequest.ChatId, StringComparison.Ordinal) &&
                   string.Equals(Phone, chatOperationsRequest.Phone, StringComparison.Ordinal);
        }

        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is IChatOperationsRequest other && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((ChatId is null ? 0 : ChatId.GetHashCode()) * 397) ^ 
                        (Phone is null ? 0 : Phone.GetHashCode());
            }
        }

        public static bool operator == (ChatOperationsRequest? left, ChatOperationsRequest? right) => EquatableHelper.IsEquatable(left, right);
        public static bool operator != (ChatOperationsRequest? left, ChatOperationsRequest? right) => !EquatableHelper.IsEquatable(left, right);
    }
}