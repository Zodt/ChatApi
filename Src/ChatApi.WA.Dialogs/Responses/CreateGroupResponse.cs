using System;
using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Dialogs.Responses.Interfaces;

namespace ChatApi.WA.Dialogs.Responses
{
    public sealed class CreateGroupResponse : Printable, ICreateGroupResponse
    {
        #region Properties

        public bool? Created { get; set; }
        public string? ChatId { get; set; }
        public string? Message { get; set; }
        public string? ErrorMessage { get; set; }
        public string? GroupInviteLink { get; set; }

        #endregion

        #region Equatable

        public bool Equals(ICreateGroupResponse? other)
        {
            return other is not null && Created == other.Created &&
                   string.Equals(ChatId, other.ChatId, StringComparison.Ordinal) &&
                   string.Equals(Message, other.Message, StringComparison.Ordinal) &&
                   string.Equals(GroupInviteLink, other.GroupInviteLink, StringComparison.Ordinal) &&
                   string.Equals(ErrorMessage, other.ErrorMessage, StringComparison.Ordinal);
        }

        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is CreateGroupResponse other && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = Created.GetHashCode();
                hashCode = (hashCode * 397) ^ (ChatId is null ? 0 : ChatId.GetHashCode());
                hashCode = (hashCode * 397) ^ (Message  is null ? 0 : Message.GetHashCode());
                hashCode = (hashCode * 397) ^ (ErrorMessage  is null ? 0 : ErrorMessage.GetHashCode());
                hashCode = (hashCode * 397) ^ (GroupInviteLink  is null ? 0 : GroupInviteLink.GetHashCode());
                return hashCode;
            }
        }

        public static bool operator == (CreateGroupResponse? left, CreateGroupResponse? right) => EquatableHelper.IsEquatable(left, right);
        public static bool operator != (CreateGroupResponse? left, CreateGroupResponse? right) => !EquatableHelper.IsEquatable(left, right);

        #endregion

        #region Printable

        protected override void PrintContent(int shift)
        {
            AddMember(nameof(Created), Created, shift);
            AddMember(nameof(ChatId), ChatId, shift);
            AddMember(nameof(Message), Message, shift);
            AddMember(nameof(GroupInviteLink), GroupInviteLink, shift);
            AddMember(nameof(ErrorMessage), ErrorMessage, shift);
        }

        #endregion
    }
}