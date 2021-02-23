using System;
using ChatApi.Core.Helpers;
using ChatApi.Core.Models.Interfaces;

namespace ChatApi.WA.Dialogs.Helpers.Abstract
{
    public abstract class MessageRequest : IMessageRequest, IEquatable<IMessageRequest?>
    {
        public string? Phone { get; set; }
        public string? ChatId { get; set; }

        public bool Equals(IMessageRequest? other)
        {
            return 
                other is not null &&
                ChatId == other.ChatId && 
                Phone == other.Phone;
        }

        public override bool Equals(object? obj) => ReferenceEquals(this, obj) || obj is IMessageRequest self && Equals(self);

        public override int GetHashCode()
        {
            unchecked
            {
                return ((string.IsNullOrWhiteSpace(ChatId) ? 0 : ChatId!.GetHashCode()) * 397) ^ 
                       (string.IsNullOrWhiteSpace(Phone) ? 0 : Phone!.GetHashCode());
            }
        }

        public static bool operator == (MessageRequest? left, MessageRequest? right) => EquatableHelper.IsEquatable(left, right);
        public static bool operator != (MessageRequest? left, MessageRequest? right) => !EquatableHelper.IsEquatable(left, right);
    }
}