using System;

using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Dialogs.Models.Interfaces;
using ChatApi.WA.Dialogs.Responses.UI.Interfaces;

namespace ChatApi.WA.Dialogs.Responses.UI
{
    public sealed class LabelCreateResponse : Printable, ILabelCreateResponse
    {
        #region Properties

        public bool? Success
        {
            get => string.Equals(Result, "success", StringComparison.Ordinal);
            set { }
        }
        public string? Result { get; set; }
        public ILabel? LabelInfo { get; set; }
        public string? ErrorMessage { get; set; }

        #endregion

        #region Equatable

        public bool Equals(ILabelCreateResponse? other)
        {
            return other is not null && Success == other.Success && LabelInfo == other.LabelInfo && 
                   string.Equals(Result,other.Result, StringComparison.Ordinal) &&
                   string.Equals(ErrorMessage,other.ErrorMessage, StringComparison.Ordinal);
        }

        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is ILabelCreateResponse other && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = Success.GetHashCode();
                hashCode = (hashCode * 397) ^ (Result is null ? 0 : Result.GetHashCode());
                hashCode = (hashCode * 397) ^ (LabelInfo is null ? 0 : LabelInfo.GetHashCode());
                hashCode = (hashCode * 397) ^ (ErrorMessage is null ? 0 : ErrorMessage.GetHashCode());
                return hashCode;
            }
        }

        public static bool operator == (LabelCreateResponse? left, LabelCreateResponse? right) => EquatableHelper.IsEquatable(left, right);
        public static bool operator != (LabelCreateResponse? left, LabelCreateResponse? right) => !EquatableHelper.IsEquatable(left, right);

        #endregion
        
        #region Printable

        protected override void PrintContent(int shift)
        {
            AddMember(nameof(Success), Success, shift);
            AddMember(nameof(Result), Result, shift);
            AddMember(nameof(LabelInfo), LabelInfo, shift);
            AddMember(nameof(ErrorMessage), ErrorMessage, shift);
        }

        #endregion
    }
}