using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Dialogs.Models.Interfaces;
using ChatApi.WA.Dialogs.Responses.Interfaces;

namespace ChatApi.WA.Dialogs.Responses
{
    public sealed class RemoveDialogResponse : Printable, IRemoveDialogResponse
    {
        #region Properties

        public string? ErrorMessage { get; set; }
        public IOperationMessageResult? Result { get; set; }

        #endregion

        #region Equatable

        public bool Equals(IRemoveDialogResponse? other)
        {
            return other is not null && 
                   ErrorMessage == other.ErrorMessage && 
                   Result == other.Result;
        }

        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is IRemoveDialogResponse other && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((Result is not null ? Result.GetHashCode() : 0) * 397) ^ 
                       (string.IsNullOrWhiteSpace(ErrorMessage) ? 0 : ErrorMessage!.GetHashCode());
            }
        }

        public static bool operator == (RemoveDialogResponse? left, RemoveDialogResponse? right) => EquatableHelper.IsEquatable(left, right);
        public static bool operator != (RemoveDialogResponse? left, RemoveDialogResponse? right) => !EquatableHelper.IsEquatable(left, right);

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
