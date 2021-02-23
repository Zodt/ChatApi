using System;
using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Dialogs.Helpers.Collections;
using ChatApi.WA.Dialogs.Models.Interfaces;

namespace ChatApi.WA.Dialogs.Models
{
    public sealed class AdditionalChatInfo : Printable, IAdditionalChatInfo
    {
        #region Properties

        public bool? IsGroup { get; set; }
        public string? GroupInviteLink { get; set; }
        public ParticipantsCollection? Participants { get; set; }

        #endregion

        #region Equatable

        public bool Equals(IAdditionalChatInfo? other)
        {
            return 
                other is not null &&
                string.Equals(GroupInviteLink, other.GroupInviteLink, StringComparison.Ordinal) &&
                IsGroup == other.IsGroup &&
                Participants == other.Participants;
        }

        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is IAdditionalChatInfo other && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = GroupInviteLink != null ? GroupInviteLink.GetHashCode() : 0;
                hashCode = (hashCode * 397) ^ IsGroup.GetHashCode();
                hashCode = (hashCode * 397) ^ (Participants != null ? Participants.GetHashCode() : 0);
                return hashCode;
            }
        }

        public static bool operator == (AdditionalChatInfo? left, AdditionalChatInfo? right) => EquatableHelper.IsEquatable(left, right);
        public static bool operator != (AdditionalChatInfo? left, AdditionalChatInfo? right) => !EquatableHelper.IsEquatable(left, right);

        #endregion
        protected override void PrintContent(int shift)
        {
            AddMember(nameof(IsGroup), IsGroup, shift);
            AddMember(nameof(GroupInviteLink), GroupInviteLink, shift);
            AddMember(nameof(Participants), Participants?.PrintMembers(3, shift), shift);
        }
    }
}