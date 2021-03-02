using System;
using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Dialogs.Responses.Interfaces;

namespace ChatApi.WA.Dialogs.Responses
{
    /// <inheritdoc cref="ChatApi.WA.Dialogs.Responses.Interfaces.ICreateGroupResponse" />
    public sealed class CreateGroupResponse : Printable, ICreateGroupResponse
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

        /// <inheritdoc />
        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is CreateGroupResponse other && Equals(other);
        }

        /// <inheritdoc />
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

        /// <summary/>
        public static bool operator == (CreateGroupResponse? left, CreateGroupResponse? right) => EquatableHelper.IsEquatable(left, right);
        /// <summary/>
        public static bool operator != (CreateGroupResponse? left, CreateGroupResponse? right) => !EquatableHelper.IsEquatable(left, right);

        #endregion

        #region Printable

        /// <inheritdoc />
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