using System;
using ChatApi.Core.Helpers;
using ChatApi.Core.Models.Interfaces;

namespace ChatApi.WA.Dialogs.Helpers.Abstract
{
    /// <inheritdoc cref="ChatApi.Core.Models.Interfaces.IMessageRequest" />
    public abstract class MessageRequest : IMessageRequest, IEquatable<IMessageRequest?>
    {

        #region Properties

        /// <inheritdoc />
        public string? Phone { get; set; }

        /// <inheritdoc />
        public string? ChatId { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(IMessageRequest? other)
        {
            return
                other is not null &&
                ChatId == other.ChatId &&
                Phone == other.Phone;
        }

        /// <inheritdoc />
        public override bool Equals(object? obj) => ReferenceEquals(this, obj) || obj is IMessageRequest self && Equals(self);

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked
            {
                return ((string.IsNullOrWhiteSpace(ChatId) ? 0 : ChatId!.GetHashCode()) * 397) ^
                       (string.IsNullOrWhiteSpace(Phone) ? 0 : Phone!.GetHashCode());
            }
        }

        /// <summary/>
        public static bool operator ==(MessageRequest? left, MessageRequest? right)
        {
            return EquatableHelper.IsEquatable(left, right);
        }
        /// <summary/>
        public static bool operator !=(MessageRequest? left, MessageRequest? right)
        {
            return !EquatableHelper.IsEquatable(left, right);
        }

        #endregion

    }
}
