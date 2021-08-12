using System;
using ChatApi.Core.Helpers;
using ChatApi.Core.Models.Interfaces;
using ChatApi.WA.Dialogs.Requests.UI.Interfaces;

namespace ChatApi.WA.Dialogs.Requests.UI
{
    /// <inheritdoc />
    public abstract class ChatOperationsRequest : IChatOperationsRequest
    {

        #region Properties

        /// <inheritdoc />
        public string? ChatId { get; set; }

        /// <inheritdoc />
        public string? Phone { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(IMessageRequest? other)
        {
            return other is IChatOperationsRequest chatOperationsRequest &&
                   string.Equals(ChatId, chatOperationsRequest.ChatId, StringComparison.Ordinal) &&
                   string.Equals(Phone, chatOperationsRequest.Phone, StringComparison.Ordinal);
        }

        /// <inheritdoc />
        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is IChatOperationsRequest other && Equals(other);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked
            {
                return ((ChatId is null ? 0 : ChatId.GetHashCode()) * 397) ^
                       (Phone is null ? 0 : Phone.GetHashCode());
            }
        }

        /// <summary/>
        public static bool operator ==(ChatOperationsRequest? left, ChatOperationsRequest? right)
        {
            return EquatableHelper.IsEquatable(left, right);
        }
        /// <summary/>
        public static bool operator !=(ChatOperationsRequest? left, ChatOperationsRequest? right)
        {
            return !EquatableHelper.IsEquatable(left, right);
        }

        #endregion

    }
}
