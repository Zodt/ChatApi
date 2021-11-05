using System;
using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Account.Models.Interfaces;

namespace ChatApi.WA.Account.Models
{
    /// <summary/>
    public record InstanceStatus : IExpiry, ILogout, IRetry, ITakeover, ILearnMore
    {

        #region Properties

        /// <inheritdoc />
        public string? Link { get; set; }

        /// <inheritdoc />
        public string? Label { get; set; }

        /// <inheritdoc />
        public InstanceStatusActionType? ActionType { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(IInstanceStatus? other)
        {
            return other is not null && ActionType == other.ActionType &&
                   string.Equals(Link, other.Link, StringComparison.Ordinal) &&
                   string.Equals(Label, other.Label, StringComparison.Ordinal);
        }

        #endregion

    }
}
