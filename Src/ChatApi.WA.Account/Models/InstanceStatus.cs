using System;
using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Account.Models.Interfaces;

namespace ChatApi.WA.Account.Models
{
    /// <summary/>
    public class InstanceStatus : Printable, IExpiry, ILogout, IRetry, ITakeover, ILearnMore
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

        /// <inheritdoc />
        public override bool Equals(object? obj) => 
            ReferenceEquals(this, obj) || obj is IInstanceStatus other && Equals(other);

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = ActionType is not null ? ActionType.GetHashCode() : 0;
                hashCode = (hashCode * 397) ^ (Label is not null ? Label.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Link is not null ? Link.GetHashCode() : 0);
                return hashCode;
            }
        }

        /// <summary/>
        public static bool operator == (InstanceStatus? left, InstanceStatus? right) => EquatableHelper.IsEquatable(left, right);
        /// <summary/>
        public static bool operator != (InstanceStatus? left, InstanceStatus? right) => !EquatableHelper.IsEquatable(left, right);

        #endregion

        #region Printable

        /// <inheritdoc />
        protected override void PrintContent(int shift)
        {
            AddMember(nameof(ActionType), ActionType, shift);
            AddMember(nameof(Label), Label, shift);
            AddMember(nameof(Link), Link, shift);
        }

        #endregion
    }
}