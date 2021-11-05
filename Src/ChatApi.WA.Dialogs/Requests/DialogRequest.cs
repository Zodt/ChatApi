using System;
using ChatApi.Core.Helpers;
using ChatApi.WA.Dialogs.Requests.Interfaces;

namespace ChatApi.WA.Dialogs.Requests
{
    /// <inheritdoc />
    public sealed record DialogRequest : IDialogRequest
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

        #endregion
    }
}