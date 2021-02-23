using ChatApi.Core.Helpers;
using ChatApi.WA.Dialogs.Helpers.Collections;
using ChatApi.WA.Dialogs.Responses.Interfaces;

namespace ChatApi.WA.Dialogs.Responses
{
    public sealed class DialogCollectionResponse : IDialogCollectionResponse
    {
        public string? ErrorMessage { get; set; }
        public DialogCollection? Dialogs { get; set; }


        public bool Equals(IDialogCollectionResponse? other)
        {
            return other is not null && 
                   Dialogs == other.Dialogs && 
                   ErrorMessage == other.ErrorMessage;
        }

        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is IDialogCollectionResponse other && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((Dialogs is not null ? Dialogs.GetHashCode() : 0) * 397) ^
                       (string.IsNullOrWhiteSpace(ErrorMessage) ? 0 : ErrorMessage!.GetHashCode());
            }
        }

        public static bool operator == (DialogCollectionResponse? left, DialogCollectionResponse? right) => EquatableHelper.IsEquatable(left, right);
        public static bool operator != (DialogCollectionResponse? left, DialogCollectionResponse? right) => !EquatableHelper.IsEquatable(left, right);
    }
}