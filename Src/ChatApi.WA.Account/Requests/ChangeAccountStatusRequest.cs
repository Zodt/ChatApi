using System;
using ChatApi.Core.Helpers;
using ChatApi.WA.Account.Requests.Interfaces;

namespace ChatApi.WA.Account.Requests
{
    /// <summary/>
    public sealed record ChangeAccountStatusRequest : IChangeAccountStatusRequest
    {
        /// <inheritdoc />
        public string? AccountStatus { get; set; }

        /// <inheritdoc />
        public bool Equals(IChangeAccountStatusRequest? other) => other is not null &&
                                                                  string.Equals(AccountStatus, other.AccountStatus, StringComparison.Ordinal);

    }
}
