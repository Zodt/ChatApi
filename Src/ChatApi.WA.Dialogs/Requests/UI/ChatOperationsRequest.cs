using System;
using ChatApi.Core.Helpers;
using ChatApi.Core.Models.Interfaces;
using ChatApi.WA.Dialogs.Requests.UI.Interfaces;

namespace ChatApi.WA.Dialogs.Requests.UI
{
    /// <inheritdoc />
    public abstract record ChatOperationsRequest : IChatOperationsRequest
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

        #endregion

    }
}
