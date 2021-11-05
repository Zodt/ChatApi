using System;
using ChatApi.Core.Helpers;
using ChatApi.WA.Dialogs.Requests.Interfaces;

namespace ChatApi.WA.Dialogs.Requests
{
    /// <inheritdoc />
    public sealed record JoinGroupRequest : IJoinGroupRequest
    {

        #region Properties

        /// <inheritdoc />
        public string? InvitationLink { get; set; }

        /// <inheritdoc />
        public string? InvitationCode { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(IJoinGroupRequest? other)
        {
            return other is not null &&
                   string.Equals(InvitationLink, other.InvitationLink, StringComparison.Ordinal) &&
                   string.Equals(InvitationCode, other.InvitationCode, StringComparison.Ordinal);
        }

        #endregion

    }
}
