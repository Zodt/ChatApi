using System;
using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Dialogs.Models.Interfaces;

namespace ChatApi.WA.Dialogs.Models
{
    /// <inheritdoc cref="ChatApi.WA.Dialogs.Models.Interfaces.IDialogStatusOperation" />
    public abstract class DialogStatusOperation : Printable, IDialogStatusOperation
    {
        #region Properties

        /// <inheritdoc />
        public bool? Success { get; set; }
        
        /// <inheritdoc />
        public string? Result { get; set; }
        
        /// <inheritdoc />
        public string? ErrorMessage { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(IDialogStatusOperation? other)
        {
            return other is not null && Success == other.Success && 
                   string.Equals(Result, other.Result, StringComparison.Ordinal) &&
                   string.Equals(ErrorMessage, other.ErrorMessage, StringComparison.Ordinal);
        }

        /// <inheritdoc />
        public override bool Equals(object? obj) => ReferenceEquals(this, obj) || obj is IDialogStatusOperation self && Equals(self);

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = Success.GetHashCode();
                hashCode = (hashCode * 397) ^ (string.IsNullOrWhiteSpace(Result) ? 0 : Result!.GetHashCode());
                hashCode = (hashCode * 397) ^ (string.IsNullOrWhiteSpace(ErrorMessage) ? 0 : ErrorMessage!.GetHashCode());
                return hashCode;
            }
        }

        /// <summary/>
        public static bool operator == (DialogStatusOperation? left, DialogStatusOperation? right) => EquatableHelper.IsEquatable(left, right);
        /// <summary/>
        public static bool operator != (DialogStatusOperation? left, DialogStatusOperation? right) => !EquatableHelper.IsEquatable(left, right);

        #endregion

        #region Printable

        /// <inheritdoc />
        protected override void PrintContent(int shift)
        {
            AddMember(nameof(Success), Success, shift);
            AddMember(nameof(Result), Result, shift);
            AddMember(nameof(ErrorMessage), ErrorMessage, shift);
        }

        #endregion
    }
}