using System;
using ChatApi.Core.Helpers;
using ChatApi.WA.Account.Requests.Interfaces;

namespace ChatApi.WA.Account.Requests
{
    /// <inheritdoc />
    public sealed class ChangeAccountNameRequest : IChangeAccountNameRequest
    {
        /// <inheritdoc />
        public string? AccountName { get; set; }

        /// <inheritdoc />
        public bool Equals(IChangeAccountNameRequest? other) => other is not null &&
                                                                string.Equals(AccountName, other.AccountName, StringComparison.Ordinal);
        /// <inheritdoc />
        public override int GetHashCode() => AccountName != null ? AccountName.GetHashCode() : 0;
        /// <inheritdoc />
        public override bool Equals(object? obj) => ReferenceEquals(this, obj) || obj is IChangeAccountNameRequest other && Equals(other);
        /// <summary/>
        public static bool operator ==(ChangeAccountNameRequest? left, ChangeAccountNameRequest? right)
        {
            return EquatableHelper.IsEquatable(left, right);
        }
        /// <summary/>
        public static bool operator !=(ChangeAccountNameRequest? left, ChangeAccountNameRequest? right)
        {
            return !EquatableHelper.IsEquatable(left, right);
        }
    }
}
