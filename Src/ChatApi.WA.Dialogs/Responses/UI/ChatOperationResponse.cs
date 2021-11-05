using System;
using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Dialogs.Responses.UI.Interfaces;

namespace ChatApi.WA.Dialogs.Responses.UI
{
    /// <inheritdoc cref="ChatApi.WA.Dialogs.Responses.UI.Interfaces.IChatOperationResponse" />
    public abstract record ChatOperationResponse : IChatOperationResponse
    {

        #region Properties

        /// <inheritdoc />
        public string? ChatId { get; set; }

        /// <inheritdoc />
        public ChatApiStatusOperation? Result { get; set; }

        /// <inheritdoc />
        public string? ErrorMessage { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(IChatOperationResponse? other)
        {
            return other is not null && Result == other.Result &&
                   string.Equals(ChatId, other.ChatId, StringComparison.Ordinal) &&
                   string.Equals(ErrorMessage, other.ErrorMessage, StringComparison.Ordinal);
        }

        #endregion

    }
}
