using System;
using ChatApi.Core.Helpers;
using ChatApi.WA.Dialogs.Models.Interfaces;

namespace ChatApi.WA.Dialogs.Models
{
    /// <summary/>
    public abstract record ParticipantRequest : IParticipantRequest
    {

        #region Properties

        /// <inheritdoc />
        public string? GroupId { get; set; }

        /// <inheritdoc />
        public string? ParticipantChatId { get; set; }

        /// <inheritdoc />
        public string? ParticipantPhone { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(IParticipantRequest? other)
        {
            return other is not null &&
                   string.Equals(GroupId, other.GroupId, StringComparison.Ordinal) &&
                   string.Equals(ParticipantPhone, other.ParticipantPhone, StringComparison.Ordinal) &&
                   string.Equals(ParticipantChatId, other.ParticipantChatId, StringComparison.Ordinal);
        }

        #endregion

    }
}
