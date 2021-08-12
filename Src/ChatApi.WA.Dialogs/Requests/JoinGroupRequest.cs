using System;
using ChatApi.Core.Helpers;
using ChatApi.WA.Dialogs.Requests.Interfaces;

namespace ChatApi.WA.Dialogs.Requests
{
    /// <inheritdoc />
    public sealed class JoinGroupRequest : IJoinGroupRequest
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

        /// <inheritdoc />
        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is IJoinGroupRequest other && Equals(other);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked
            {
                return ((InvitationLink is null ? 0 : InvitationLink.GetHashCode()) * 397) ^
                       (InvitationCode is null ? 0 : InvitationCode.GetHashCode());
            }
        }

        /// <summary/>
        public static bool operator ==(JoinGroupRequest? left, JoinGroupRequest? right)
        {
            return EquatableHelper.IsEquatable(left, right);
        }
        /// <summary/>
        public static bool operator !=(JoinGroupRequest? left, JoinGroupRequest? right)
        {
            return !EquatableHelper.IsEquatable(left, right);
        }

        #endregion

    }
}
