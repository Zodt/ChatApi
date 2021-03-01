using System;
using ChatApi.Core.Helpers;
using ChatApi.WA.Account.Requests.Interfaces;

namespace ChatApi.WA.Account.Requests
{
    /// <summary/>
    public sealed class ChangeAccountStatusRequest : IChangeAccountStatusRequest
    {
        /// <inheritdoc />
        public string? AccountStatus { get; set; }

        /// <inheritdoc />
        public bool Equals(IChangeAccountStatusRequest? other) => other is not null &&
                                                                  string.Equals(AccountStatus, other.AccountStatus, StringComparison.Ordinal);
        /// <inheritdoc />
        public override int GetHashCode() => AccountStatus != null ? AccountStatus.GetHashCode() : 0;
        /// <inheritdoc />
        public override bool Equals(object? obj) => ReferenceEquals(this, obj) || obj is IChangeAccountStatusRequest other && Equals(other);
        /// <summary/>
        public static bool operator == (ChangeAccountStatusRequest? left, ChangeAccountStatusRequest? right) => EquatableHelper.IsEquatable(left, right);
        /// <summary/>
        public static bool operator != (ChangeAccountStatusRequest? left, ChangeAccountStatusRequest? right) => !EquatableHelper.IsEquatable(left, right);
    }
}