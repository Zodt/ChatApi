using System.Text;
using ChatApi.Core.Helpers;
using ChatApi.WA.Dialogs.Requests.Interfaces;

namespace ChatApi.WA.Dialogs.Requests
{
    public sealed class DialogCollectionRequest : IDialogCollectionRequest
    {
        public int Page { get; set; }
        public int Limit { get; set; }

        public DialogCollectionRequest() { }
        public DialogCollectionRequest(int limit) => Limit = limit;
        public DialogCollectionRequest(int limit, int page) => (Limit, Page) = (limit, page);
        
        public string Parameters
        {
            get
            {
                StringBuilder stringBuilder = new();
                stringBuilder.Append(string.Concat("&", nameof(Limit).ToLower(), "=", Limit));
                stringBuilder.Append(string.Concat("&", nameof(Page).ToLower(), "=", Page));
                return stringBuilder.ToString();
            }
        }        
        
        public bool Equals(IDialogCollectionRequest? other)
        {
            return other is not null &&
                   Page == other.Page &&
                   Limit == other.Limit;
        }

        public override bool Equals(object obj)
        {
            return ReferenceEquals(this, obj) || obj is DialogCollectionRequest other && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (Page * 397) ^ Limit;
            }
        }

        public static bool operator == (DialogCollectionRequest? left, DialogCollectionRequest? right) => EquatableHelper.IsEquatable(left, right);
        public static bool operator != (DialogCollectionRequest? left, DialogCollectionRequest? right) => !EquatableHelper.IsEquatable(left, right);


    }
}