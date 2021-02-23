using System;
using ChatApi.Core.Helpers;
using ChatApi.WA.Dialogs.Models.Interfaces;

namespace ChatApi.WA.Dialogs.Models
{
    public abstract class ParticipantRequest : IParticipantRequest
    {
        public string? GroupId { get; set; }
        public string? ParticipantChatId { get; set; }
        public string? ParticipantPhone { get; set; }

        public bool Equals(IParticipantRequest? other)
        {
            return other is not null &&
                   string.Equals(GroupId, other.GroupId, StringComparison.Ordinal) &&
                   string.Equals(ParticipantPhone, other.ParticipantPhone, StringComparison.Ordinal) &&
                   string.Equals(ParticipantChatId, other.ParticipantChatId, StringComparison.Ordinal);
        }

        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is IParticipantRequest other && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = GroupId is null ? 0 : GroupId.GetHashCode();
                hashCode = (hashCode * 397) ^ (ParticipantPhone is null ? 0 : ParticipantPhone.GetHashCode());
                hashCode = (hashCode * 397) ^ (ParticipantChatId is null ? 0 : ParticipantChatId.GetHashCode());
                return hashCode;
            }
        }

        public static bool operator == (ParticipantRequest? left, ParticipantRequest? right) => EquatableHelper.IsEquatable(left, right);
        public static bool operator != (ParticipantRequest? left, ParticipantRequest? right) => !EquatableHelper.IsEquatable(left, right);
    }
}