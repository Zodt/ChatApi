using System;
using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Dialogs.Models.Interfaces;

namespace ChatApi.WA.Dialogs.Models
{
    public sealed class OperationMessageResult : Printable, IOperationMessageResult
    {
        #region Properties

        public string? Message { get; set; }

        #endregion

        #region Equatable

        public override int GetHashCode() => Message != null ? Message.GetHashCode() : 0;
        public bool Equals(IOperationMessageResult? other) => other is not null && 
                                                              string.Equals(Message, other.Message, StringComparison.Ordinal);
        public override bool Equals(object? obj) => Equals(null, obj) || obj is IOperationMessageResult other && Equals(other);
        public static bool operator == (OperationMessageResult? left, OperationMessageResult? right) => EquatableHelper.IsEquatable(left, right);
        public static bool operator != (OperationMessageResult? left, OperationMessageResult? right) => !EquatableHelper.IsEquatable(left, right);

        #endregion

        #region Printable

        protected override void PrintContent(int shift)
        {
            AddMember(nameof(Message), Message, shift);
        }

        #endregion
    }
}