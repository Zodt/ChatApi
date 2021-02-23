using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Dialogs.Helpers.Collections;
using ChatApi.WA.Dialogs.Requests.Interfaces;

namespace ChatApi.WA.Dialogs.Requests
{
    public sealed class CreateGroupRequest : Printable, ICreateGroupRequest
    {
        #region Properties

        public string? Avatar { get; set; }
        public string? Preview { get; set; }
        public string? GroupName { get; set; }
        public string? MessageText { get; set; }
        public PhonesCollection? Phones { get; set; }
        public ChatIdsCollection? ChatIds { get; set; }

        #endregion

        #region Equatable

        public bool Equals(ICreateGroupRequest? other)
        {
            return other is not null &&
                   
                   Avatar == other.Avatar && 
                   Preview == other.Preview && 
                   GroupName == other.GroupName && 
                   Phones == other.Phones && 
                   ChatIds == other.ChatIds && 
                   MessageText == other.MessageText;
        }

        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is ICreateGroupRequest other && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = string.IsNullOrWhiteSpace(Avatar) ? 0 : Avatar!.GetHashCode();
                hashCode = (hashCode * 397) ^ (string.IsNullOrWhiteSpace(Preview) ? 0 : Preview!.GetHashCode());
                hashCode = (hashCode * 397) ^ (string.IsNullOrWhiteSpace(GroupName) ? 0 : GroupName!.GetHashCode());
                
                hashCode = (hashCode * 397) ^ (Phones != null ? Phones.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (ChatIds != null ? ChatIds.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (MessageText != null ? MessageText.GetHashCode() : 0);
                
                return hashCode;
            }
        }

        public static bool operator == (CreateGroupRequest? left, CreateGroupRequest? right) => EquatableHelper.IsEquatable(left, right);
        public static bool operator != (CreateGroupRequest? left, CreateGroupRequest? right) => !EquatableHelper.IsEquatable(left, right);

        #endregion

        #region Printable

        protected override void PrintContent(int shift)
        {
            AddMember(nameof(Avatar), Avatar, shift);
            AddMember(nameof(Preview), Preview, shift);
            AddMember(nameof(GroupName), GroupName, shift);
            AddMember(nameof(MessageText), MessageText, shift);
            AddMember(nameof(Phones), Phones?.PrintMembers(shift), shift);
            AddMember(nameof(ChatIds), ChatIds?.PrintMembers(shift), shift);
        }

        #endregion
    }
}