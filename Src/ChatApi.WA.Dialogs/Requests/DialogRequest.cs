using System;
using ChatApi.Core.Helpers;
using ChatApi.WA.Dialogs.Requests.Interfaces;

namespace ChatApi.WA.Dialogs.Requests
{
    public sealed class DialogRequest : IDialogRequest
    {
        public string? ChatId { get; set; }

        public string Parameters => string.Concat("&chatId=", ChatId);

        public bool Equals(IDialogRequest? other) => other is not null &&
            string.Equals(ChatId, other.ChatId, StringComparison.Ordinal);
        public override int GetHashCode() => ChatId != null ? ChatId.GetHashCode() : 0;
        public static bool operator ==(DialogRequest? left, DialogRequest? right) => EquatableHelper.IsEquatable(left, right);
        public static bool operator !=(DialogRequest? left, DialogRequest? right) => !EquatableHelper.IsEquatable(left, right);
        public override bool Equals(object? obj) => ReferenceEquals(null, obj) || obj is IDialogRequest other && Equals(other);
    }
}