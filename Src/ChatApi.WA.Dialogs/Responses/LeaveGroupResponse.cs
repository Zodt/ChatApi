using System;
using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Dialogs.Models.Interfaces;
using ChatApi.WA.Dialogs.Responses.Interfaces;

namespace ChatApi.WA.Dialogs.Responses
{
    /// <inheritdoc cref="ChatApi.WA.Dialogs.Responses.Interfaces.ILeaveGroupResponse" />
    public sealed class LeaveGroupResponse : Printable, ILeaveGroupResponse
    {
        #region Properties

        /// <inheritdoc />
        public string? ErrorMessage { get; set; }
        
        /// <inheritdoc />
        public IOperationMessageResult? Result { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(ILeaveGroupResponse? other)
        {
            return other is not null && 
                   string.Equals(ErrorMessage, other.ErrorMessage, StringComparison.Ordinal) &&
                   Result == other.Result;
        }

        /// <inheritdoc />
        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is ILeaveGroupResponse other && Equals(other);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked
            {
                return ((ErrorMessage != null ? ErrorMessage.GetHashCode() : 0) * 397) ^ (Result != null ? Result.GetHashCode() : 0);
            }
        }

        /// <summary/>
        public static bool operator == (LeaveGroupResponse? left, LeaveGroupResponse? right) => EquatableHelper.IsEquatable(left, right);
        /// <summary/>
        public static bool operator != (LeaveGroupResponse? left, LeaveGroupResponse? right) => !EquatableHelper.IsEquatable(left, right);

        #endregion

        #region Printable

        /// <inheritdoc />
        protected override void PrintContent(int shift)
        {
            AddMember(nameof(Result), Result, shift);
            AddMember(nameof(ErrorMessage), ErrorMessage, shift);
        }

        #endregion
    }
}