using System;
using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Dialogs.Helpers.Collections;
using ChatApi.WA.Dialogs.Models.Interfaces;

namespace ChatApi.WA.Dialogs.Models
{
    /// <inheritdoc cref="ChatApi.WA.Dialogs.Models.Interfaces.IAdditionalChatInfo" />
    public sealed record AdditionalChatInfo : IAdditionalChatInfo
    {

        #region Properties

        /// <inheritdoc />
        public bool? IsGroup { get; set; }

        /// <inheritdoc />
        public string? GroupInviteLink { get; set; }

        /// <inheritdoc />
        public ParticipantsCollection? Participants { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(IAdditionalChatInfo? other)
        {
            return
                other is not null &&
                string.Equals(GroupInviteLink, other.GroupInviteLink, StringComparison.Ordinal) &&
                IsGroup == other.IsGroup &&
                Participants == other.Participants;
        }

        #endregion

    }
}
