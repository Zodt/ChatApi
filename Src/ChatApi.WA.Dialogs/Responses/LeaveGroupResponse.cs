using System;
using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Dialogs.Models.Interfaces;
using ChatApi.WA.Dialogs.Responses.Interfaces;

namespace ChatApi.WA.Dialogs.Responses
{
    public sealed class LeaveGroupResponse : Printable, ILeaveGroupResponse
    {
        #region Properties

        public string? ErrorMessage { get; set; }
        public IOperationMessageResult? Result { get; set; }

        #endregion

        #region Equatable

        public bool Equals(ILeaveGroupResponse? other)
        {
            return other is not null && 
                   string.Equals(ErrorMessage, other.ErrorMessage, StringComparison.Ordinal) &&
                   Result == other.Result;
        }

        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is ILeaveGroupResponse other && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((ErrorMessage != null ? ErrorMessage.GetHashCode() : 0) * 397) ^ (Result != null ? Result.GetHashCode() : 0);
            }
        }

        public static bool operator == (LeaveGroupResponse? left, LeaveGroupResponse? right) => EquatableHelper.IsEquatable(left, right);
        public static bool operator != (LeaveGroupResponse? left, LeaveGroupResponse? right) => !EquatableHelper.IsEquatable(left, right);

        #endregion

        #region Printable

        protected override void PrintContent(int shift)
        {
            AddMember(nameof(Result), Result, shift);
            AddMember(nameof(ErrorMessage), ErrorMessage, shift);
        }

        #endregion
    }
}