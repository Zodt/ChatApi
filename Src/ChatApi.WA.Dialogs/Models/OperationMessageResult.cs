using System;
using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Dialogs.Models.Interfaces;

namespace ChatApi.WA.Dialogs.Models
{
    /// <inheritdoc cref="ChatApi.WA.Dialogs.Models.Interfaces.IOperationMessageResult" />
    public sealed class OperationMessageResult : Printable, IOperationMessageResult
    {

        #region Properties

        /// <inheritdoc />
        public string? Message { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public override int GetHashCode() => Message != null ? Message.GetHashCode() : 0;
        /// <inheritdoc />
        public bool Equals(IOperationMessageResult? other)
        {
            return other is not null &&
                   string.Equals(Message, other.Message, StringComparison.Ordinal);
        }
        /// <inheritdoc />
        public override bool Equals(object? obj) => Equals(null, obj) || obj is IOperationMessageResult other && Equals(other);
        /// <summary/>
        public static bool operator ==(OperationMessageResult? left, OperationMessageResult? right)
        {
            return EquatableHelper.IsEquatable(left, right);
        }
        /// <summary/>
        public static bool operator !=(OperationMessageResult? left, OperationMessageResult? right)
        {
            return !EquatableHelper.IsEquatable(left, right);
        }

        #endregion

        #region Printable

        /// <inheritdoc />
        protected override void PrintContent(int shift)
        {
            AddMember(nameof(Message), Message, shift);
        }

        #endregion

    }
}
