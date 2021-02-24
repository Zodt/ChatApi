using System;
using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Account.Models.Interfaces;

namespace ChatApi.WA.Account.Models
{
    public class InstanceStatus : Printable, IExpiry, ILogout, IRetry, ITakeover, ILearnMore
    {
        #region Properties

        public string? Link { get; set; }
        public string? Label { get; set; }
        public InstanceStatusActionType? Action { get; set; }

        #endregion
         
        #region Equatable

        public bool Equals(IInstanceStatus? other)
        {
            return other is not null && Action == other.Action &&
                   string.Equals(Link, other.Link, StringComparison.Ordinal) &&
                   string.Equals(Label, other.Label, StringComparison.Ordinal);
        }

        public override bool Equals(object? obj) => 
            ReferenceEquals(this, obj) || obj is IInstanceStatus other && Equals(other);

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = Action is not null ? Action.GetHashCode() : 0;
                hashCode = (hashCode * 397) ^ (Label is not null ? Label.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Link is not null ? Link.GetHashCode() : 0);
                return hashCode;
            }
        }

        public static bool operator == (InstanceStatus? left, InstanceStatus? right) => EquatableHelper.IsEquatable(left, right);
        public static bool operator != (InstanceStatus? left, InstanceStatus? right) => !EquatableHelper.IsEquatable(left, right);

        #endregion

        #region Printable

        protected override void PrintContent(int shift)
        {
            AddMember(nameof(Action), Action, shift);
            AddMember(nameof(Label), Label, shift);
            AddMember(nameof(Link), Link, shift);
        }

        #endregion
    }
}