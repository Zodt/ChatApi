using System;
using ChatApi.Core.Helpers;
using ChatApi.WA.Account.Requests.Interfaces;

namespace ChatApi.WA.Account.Requests
{
    public sealed class ChangeAccountStatusRequest : IChangeAccountStatusRequest
    {
        public string? AccountStatus { get; set; }

        public bool Equals(IChangeAccountStatusRequest? other) => other is not null &&
            string.Equals(AccountStatus, other.AccountStatus, StringComparison.Ordinal);
        public override int GetHashCode() => AccountStatus != null ? AccountStatus.GetHashCode() : 0;
        public override bool Equals(object? obj) => ReferenceEquals(this, obj) || obj is IChangeAccountStatusRequest other && Equals(other);
        public static bool operator == (ChangeAccountStatusRequest? left, ChangeAccountStatusRequest? right) => EquatableHelper.IsEquatable(left, right);
        public static bool operator != (ChangeAccountStatusRequest? left, ChangeAccountStatusRequest? right) => !EquatableHelper.IsEquatable(left, right);
    }
}