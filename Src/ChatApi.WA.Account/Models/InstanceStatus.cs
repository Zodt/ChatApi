using ChatApi.Core.Converters;
using ChatApi.Core.Helpers;
using ChatApi.WA.Account.Models.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ChatApi.WA.Account.Models
{
    public class InstanceStatus : IExpiry, ILogout, IRetry, ITakeover, ILearnMore
    {
        #region Properties

        public InstanceStatusActType? Act { get; set; }
        public string? Label { get; set; }
        public string? Link { get; set; }

        #endregion
         
        #region Equatable

        public bool Equals(IInstanceStatus? other) =>
            other is not null &&
            Act == other.Act && 
            Label == other.Label && 
            Link == other.Link;

        public override bool Equals(object? obj) => 
            ReferenceEquals(this, obj) || obj is IInstanceStatus other && Equals(other);

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = Act is not null ? Act.GetHashCode() : 0;
                hashCode = (hashCode * 397) ^ (Label is not null ? Label.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Link is not null ? Link.GetHashCode() : 0);
                return hashCode;
            }
        }

        public static bool operator == (InstanceStatus? left, InstanceStatus? right) => EquatableHelper.IsEquatable(left, right);
        public static bool operator != (InstanceStatus? left, InstanceStatus? right) => !EquatableHelper.IsEquatable(left, right);

        #endregion
    }
}