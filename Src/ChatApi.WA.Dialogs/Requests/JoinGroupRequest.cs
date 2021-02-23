using System;
using ChatApi.Core.Helpers;
using ChatApi.WA.Dialogs.Requests.Interfaces;

namespace ChatApi.WA.Dialogs.Requests
{
    public sealed class JoinGroupRequest : IJoinGroupRequest
    {
        public string? InvitationLink { get; set; }
        public string? InvitationCode { get; set; }

        public bool Equals(IJoinGroupRequest? other)
        {
            return other is not null &&
                   string.Equals(InvitationLink, other.InvitationLink, StringComparison.Ordinal) &&
                   string.Equals(InvitationCode, other.InvitationCode, StringComparison.Ordinal);
        }

        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is IJoinGroupRequest other && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((InvitationLink is null ? 0 : InvitationLink.GetHashCode()) * 397) ^ 
                       (InvitationCode is null ? 0 : InvitationCode.GetHashCode());
            }
        }

        public static bool operator == (JoinGroupRequest? left, JoinGroupRequest? right) => EquatableHelper.IsEquatable(left, right);
        public static bool operator != (JoinGroupRequest? left, JoinGroupRequest? right) => !EquatableHelper.IsEquatable(left, right);
    }
}