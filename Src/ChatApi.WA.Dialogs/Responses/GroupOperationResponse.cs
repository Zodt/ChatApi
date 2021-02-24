﻿using System;
using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Dialogs.Responses.Interfaces;

namespace ChatApi.WA.Dialogs.Responses
{
    public abstract class GroupOperationResponse : Printable, IGroupOperationResponse
    {
        #region Properties

        public bool? IsSuccess { get; set; }
        public string? GroupId { get; set; }
        public string? ErrorMessage { get; set; }
        public string? StatusMessage { get; set; }

        #endregion

        #region Equatable

        public bool Equals(IGroupOperationResponse? other)
        {
            return other is not null && IsSuccess == other.IsSuccess &&
                   string.Equals(GroupId, other.GroupId, StringComparison.Ordinal) &&
                   string.Equals(ErrorMessage, other.ErrorMessage, StringComparison.Ordinal) &&
                   string.Equals(StatusMessage, other.StatusMessage, StringComparison.Ordinal);
        }

        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is IGroupOperationResponse other && Equals(other);
        }

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

        public static bool operator == (GroupOperationResponse? left, GroupOperationResponse? right) => EquatableHelper.IsEquatable(left, right);
        public static bool operator != (GroupOperationResponse? left, GroupOperationResponse? right) => !EquatableHelper.IsEquatable(left, right);

        #endregion

        #region Printable

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