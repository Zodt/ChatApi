using System;
using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Dialogs.Responses.Interfaces;

namespace ChatApi.WA.Dialogs.Responses
{
    /// <inheritdoc cref="ChatApi.WA.Dialogs.Responses.Interfaces.ICreateGroupResponse" />
    public sealed record CreateGroupResponse : ICreateGroupResponse
    {

        #region Properties

        /// <inheritdoc />
        public bool? Created { get; set; }

        /// <inheritdoc />
        public string? ChatId { get; set; }

        /// <inheritdoc />
        public string? Message { get; set; }

        /// <inheritdoc />
        public string? ErrorMessage { get; set; }

        /// <inheritdoc />
        public string? GroupInviteLink { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(ICreateGroupResponse? other)
        {
            return other is not null && Created == other.Created &&
                   string.Equals(ChatId, other.ChatId, StringComparison.Ordinal) &&
                   string.Equals(Message, other.Message, StringComparison.Ordinal) &&
                   string.Equals(GroupInviteLink, other.GroupInviteLink, StringComparison.Ordinal) &&
                   string.Equals(ErrorMessage, other.ErrorMessage, StringComparison.Ordinal);
        }

        #endregion

    }
}
