using System;
using ChatApi.Core.Helpers;
using ChatApi.WA.Dialogs.Requests.Interfaces;

namespace ChatApi.WA.Dialogs.Requests
{
    /// <inheritdoc />
    public sealed class DialogRequest : IDialogRequest
    {
        #region Properties

        /// <inheritdoc cref="IDialogRequest.ChatId" />
        public string? ChatId { get; set; }

        /// <inheritdoc />
        public string Parameters => string.Concat("&chatId=", ChatId);

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(IDialogRequest? other) => other is not null &&
                                                     string.Equals(ChatId, other.ChatId, StringComparison.Ordinal);
        /// <inheritdoc />
        public override int GetHashCode() => ChatId != null ? ChatId.GetHashCode() : 0;
        /// <summary/>
        public static bool operator ==(DialogRequest? left, DialogRequest? right) => EquatableHelper.IsEquatable(left, right);
        /// <summary/>
        public static bool operator !=(DialogRequest? left, DialogRequest? right) => !EquatableHelper.IsEquatable(left, right);
        /// <inheritdoc />
        public override bool Equals(object? obj) => ReferenceEquals(null, obj) || obj is IDialogRequest other && Equals(other);

        #endregion
    }
}