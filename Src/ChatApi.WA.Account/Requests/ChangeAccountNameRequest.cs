using System;
using ChatApi.Core.Helpers;
using ChatApi.WA.Account.Requests.Interfaces;

namespace ChatApi.WA.Account.Requests
{
    /// <inheritdoc />
    public sealed record ChangeAccountNameRequest : IChangeAccountNameRequest
    {
        /// <inheritdoc />
        public string? AccountName { get; set; }

        /// <inheritdoc />
        public bool Equals(IChangeAccountNameRequest? other) => other is not null &&
                                                                string.Equals(AccountName, other.AccountName, StringComparison.Ordinal);

    }
}
