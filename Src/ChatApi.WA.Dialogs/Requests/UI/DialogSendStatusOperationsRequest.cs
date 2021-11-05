using System;
using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Dialogs.Requests.UI.Interfaces;

namespace ChatApi.WA.Dialogs.Requests.UI
{
    /// <inheritdoc cref="ChatApi.WA.Dialogs.Requests.UI.Interfaces.IDialogSendStatusOperationsRequest" />
    public abstract record DialogSendStatusOperationsRequest : IDialogSendStatusOperationsRequest
    {

        #region Properties

        /// <inheritdoc />
        public string? Phone { get; set; }

        /// <inheritdoc />
        public string? ChatId { get; set; }

        /// <inheritdoc />
        public uint? Duration { get; set; }

        /// <inheritdoc />
        public bool? EnableStatusDisplay { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(IDialogSendStatusOperationsRequest? other)
        {
            return other is not null &&
                   string.Equals(Phone, other.Phone, StringComparison.Ordinal) &&
                   string.Equals(ChatId, other.ChatId, StringComparison.Ordinal) &&
                   Duration == other.Duration && EnableStatusDisplay == other.EnableStatusDisplay;
        }

        #endregion


    }
}
