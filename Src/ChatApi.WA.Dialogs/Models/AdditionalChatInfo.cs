using System;
using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Dialogs.Helpers.Collections;
using ChatApi.WA.Dialogs.Models.Interfaces;

namespace ChatApi.WA.Dialogs.Models
{
    /// <inheritdoc cref="ChatApi.WA.Dialogs.Models.Interfaces.IAdditionalChatInfo" />
    public sealed class AdditionalChatInfo : Printable, IAdditionalChatInfo
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

        /// <inheritdoc />
        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is IAdditionalChatInfo other && Equals(other);
        }

        /// <inheritdoc />
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

        /// <summary/>
        public static bool operator == (AdditionalChatInfo? left, AdditionalChatInfo? right) => EquatableHelper.IsEquatable(left, right);
        /// <summary/>
        public static bool operator != (AdditionalChatInfo? left, AdditionalChatInfo? right) => !EquatableHelper.IsEquatable(left, right);

        #endregion

        #region Printable

        /// <inheritdoc />
        protected override void PrintContent(int shift)
        {
            AddMember(nameof(IsGroup), IsGroup, shift);
            AddMember(nameof(GroupInviteLink), GroupInviteLink, shift);
            AddMember(nameof(Participants), Participants?.PrintMembers(3, shift), shift);
        }

        #endregion
    }
}