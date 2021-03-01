using System;
using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Dialogs.Responses.Interfaces;

namespace ChatApi.WA.Dialogs.Responses
{
    /// <inheritdoc cref="ChatApi.WA.Dialogs.Responses.Interfaces.IGroupOperationResponse" />
    public abstract class GroupOperationResponse : Printable, IGroupOperationResponse
    {
        #region Properties

        /// <inheritdoc />
        public bool? IsSuccess { get; set; }
        
        /// <inheritdoc />
        public string? GroupId { get; set; }
        
        /// <inheritdoc />
        public string? ErrorMessage { get; set; }
        
        /// <inheritdoc />
        public string? StatusMessage { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(IGroupOperationResponse? other)
        {
            return other is not null && IsSuccess == other.IsSuccess &&
                   string.Equals(GroupId, other.GroupId, StringComparison.Ordinal) &&
                   string.Equals(ErrorMessage, other.ErrorMessage, StringComparison.Ordinal) &&
                   string.Equals(StatusMessage, other.StatusMessage, StringComparison.Ordinal);
        }

        /// <inheritdoc />
        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is IGroupOperationResponse other && Equals(other);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = IsSuccess.GetHashCode();
                hashCode = (hashCode * 397) ^ (GroupId is null ? 0 : GroupId.GetHashCode());
                hashCode = (hashCode * 397) ^ (ErrorMessage is null ? 0 : ErrorMessage.GetHashCode());
                hashCode = (hashCode * 397) ^ (StatusMessage is null ? 0 : StatusMessage.GetHashCode());
                return hashCode;
            }
        }

        /// <summary/>
        public static bool operator == (GroupOperationResponse? left, GroupOperationResponse? right) => EquatableHelper.IsEquatable(left, right);
        /// <summary/>
        public static bool operator != (GroupOperationResponse? left, GroupOperationResponse? right) => !EquatableHelper.IsEquatable(left, right);

        #endregion

        #region Printable

        /// <inheritdoc />
        protected override void PrintContent(int shift)
        {
            AddMember(nameof(IsSuccess), IsSuccess, shift);
            AddMember(nameof(GroupId), GroupId, shift);
            AddMember(nameof(StatusMessage), StatusMessage, shift);
            AddMember(nameof(ErrorMessage), ErrorMessage, shift);
        }

        #endregion
        
    }
}