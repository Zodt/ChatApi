using ChatApi.Core.Helpers;
using ChatApi.WA.Account.Models;
using ChatApi.WA.Account.Models.Interfaces;
using ChatApi.WA.Account.Responses.Interfaces;

namespace ChatApi.WA.Account.Responses
{
    /// <inheritdoc cref="ChatApi.WA.Account.Responses.Interfaces.IAccountSettingsResponse" />
    public sealed class AccountSettingsResponse : AccountSettings, IAccountSettingsResponse
    {
        #region Properties

        /// <inheritdoc />
        public IAccountSettings? Update { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(IAccountSettingsResponse? other)
        {
            return other is not null && 
                   base.Equals(other) && 
                   Update == other.Update;
        }

        /// <inheritdoc />
        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is IAccountSettingsResponse other && Equals(other);
        }
        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked
            {
                return (base.GetHashCode() * 397) ^ (Update != null ? Update.GetHashCode() : 0);
            }
        }

        /// <summary/>
        public static bool operator == (AccountSettingsResponse? left, AccountSettingsResponse? right) => EquatableHelper.IsEquatable(left, right);
        /// <summary/>
        public static bool operator != (AccountSettingsResponse? left, AccountSettingsResponse? right) => !EquatableHelper.IsEquatable(left, right);

        #endregion
        
        #region Printable

        /// <inheritdoc />
        protected override void PrintContent(int shift)
        {
            AddMember(nameof(Update), Update, shift);
            base.PrintContent(shift);
        }

        #endregion
    }
}