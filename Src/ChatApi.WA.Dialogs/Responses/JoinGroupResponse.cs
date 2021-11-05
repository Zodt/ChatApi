using System;
using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Dialogs.Responses.Interfaces;

namespace ChatApi.WA.Dialogs.Responses
{
    /// <inheritdoc cref="ChatApi.WA.Dialogs.Responses.Interfaces.IJoinGroupResponse" />
    public sealed record JoinGroupResponse : IJoinGroupResponse
    {

        #region Properies

        /// <inheritdoc />
        public string? ChatId { get; set; }

        /// <inheritdoc />
        public string? ErrorMessage { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(IJoinGroupResponse? other)
        {
            return
                other is not null &&
                string.Equals(ChatId, other.ChatId, StringComparison.Ordinal) &&
                string.Equals(ErrorMessage, other.ErrorMessage, StringComparison.Ordinal);
        }

        #endregion

    }
}
