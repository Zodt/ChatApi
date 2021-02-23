using System;
using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Dialogs.Responses.UI.Interfaces;

namespace ChatApi.WA.Dialogs.Responses.UI
{
    public sealed class LabelUpdateResponse : Printable, ILabelUpdateResponse
    {
        #region Properties

        public string? ErrorMessage { get; set; }
        public string? Result { get; set; }
        public bool? Success
        {
            get => string.Equals(Result, "success", StringComparison.Ordinal); 
            set { } 
        }

        #endregion

        #region Equatable

        public bool Equals(ILabelUpdateResponse? other)
        {
            return other is not null && Success == other.Success &&
                   string.Equals(ErrorMessage, other.ErrorMessage, StringComparison.Ordinal) &&
                   string.Equals(Result, other.Result, StringComparison.Ordinal);
        }

        public override bool Equals(object? obj) => ReferenceEquals(this, obj) || obj is ILabelUpdateResponse other && Equals(other);

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = ErrorMessage != null ? ErrorMessage.GetHashCode() : 0;
                hashCode = (hashCode * 397) ^ (Result != null ? Result.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ Success.GetHashCode();
                return hashCode;
            }
        }

        public static bool operator == (LabelUpdateResponse? left, LabelUpdateResponse? right) => EquatableHelper.IsEquatable(left, right);
        public static bool operator != (LabelUpdateResponse? left, LabelUpdateResponse? right) => !EquatableHelper.IsEquatable(left, right);

        #endregion

        #region Printable

        protected override void PrintContent(int shift)
        {
            AddMember(nameof(Result), Result, shift);
            AddMember(nameof(Success), Success, shift);
            AddMember(nameof(ErrorMessage), ErrorMessage, shift);
        }

        #endregion
    }
}