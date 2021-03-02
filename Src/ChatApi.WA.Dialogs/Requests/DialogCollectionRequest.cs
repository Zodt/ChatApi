using System.Text;
using ChatApi.Core.Helpers;
using ChatApi.WA.Dialogs.Requests.Interfaces;

namespace ChatApi.WA.Dialogs.Requests
{
    /// <inheritdoc />
    public sealed class DialogCollectionRequest : IDialogCollectionRequest
    {
        #region Properties

        /// <inheritdoc />
        public int Page { get; set; }
        /// <inheritdoc />
        public int Limit { get; set; }

        /// <inheritdoc />
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

        #endregion

        #region Constructors

        /// <summary/>
        public DialogCollectionRequest() { }

        /// <summary/>
        public DialogCollectionRequest(int limit) => Limit = limit;

        /// <summary/>
        public DialogCollectionRequest(int limit, int page) => (Limit, Page) = (limit, page);

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(IDialogCollectionRequest? other)
        {
            return other is not null &&
                   Page == other.Page &&
                   Limit == other.Limit;
        }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            return ReferenceEquals(this, obj) || obj is DialogCollectionRequest other && Equals(other);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked
            {
                return (Page * 397) ^ Limit;
            }
        }

        /// <summary/>
        public static bool operator == (DialogCollectionRequest? left, DialogCollectionRequest? right) => EquatableHelper.IsEquatable(left, right);
        /// <summary/>
        public static bool operator != (DialogCollectionRequest? left, DialogCollectionRequest? right) => !EquatableHelper.IsEquatable(left, right);

        #endregion
    }
}