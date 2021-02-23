using System;
using ChatApi.Core.Helpers;
using ChatApi.WA.Account.Requests.Interfaces;

namespace ChatApi.WA.Account.Requests
{
    public sealed class ChangeAccountNameRequest : IChangeAccountNameRequest
    {
        public string? AccountName { get; set; }

        public bool Equals(IChangeAccountNameRequest? other) => other is not null &&
            string.Equals(AccountName, other.AccountName, StringComparison.Ordinal);
        public override int GetHashCode() => AccountName != null ? AccountName.GetHashCode() : 0;
        public override bool Equals(object? obj) => ReferenceEquals(this, obj) || obj is IChangeAccountNameRequest other && Equals(other);
        public static bool operator == (ChangeAccountNameRequest? left, ChangeAccountNameRequest? right) => EquatableHelper.IsEquatable(left, right);
        public static bool operator != (ChangeAccountNameRequest? left, ChangeAccountNameRequest? right) => !EquatableHelper.IsEquatable(left, right);
    }
}