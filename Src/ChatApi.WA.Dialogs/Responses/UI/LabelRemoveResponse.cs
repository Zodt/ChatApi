using System;

using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Dialogs.Responses.UI.Interfaces;

namespace ChatApi.WA.Dialogs.Responses.UI
{
    public sealed class LabelRemoveResponse : Printable, ILabelRemoveResponse
    {
        #region Properties

        public bool? Success { get; set; }
        public string? Result { get; set; }
        public string? ErrorMessage { get; set; }

        #endregion

        #region Equatable

        public bool Equals(ILabelRemoveResponse? other) => 
            other is not null && Success == other.Success && 
            string.Equals(Result, other.Result, StringComparison.Ordinal) &&
            string.Equals(ErrorMessage, other.ErrorMessage, StringComparison.Ordinal);
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
        public override bool Equals(object? obj) => ReferenceEquals(this, obj) || obj is ILabelRemoveResponse other && Equals(other);
        public static bool operator == (LabelRemoveResponse? left, LabelRemoveResponse? right) => EquatableHelper.IsEquatable(left, right);
        public static bool operator != (LabelRemoveResponse? left, LabelRemoveResponse? right) => !EquatableHelper.IsEquatable(left, right);

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