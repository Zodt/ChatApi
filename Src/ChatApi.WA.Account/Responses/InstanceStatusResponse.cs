using ChatApi.Core.Helpers;
using ChatApi.WA.Account.Models;
using ChatApi.WA.Account.Responses.Interfaces;

namespace ChatApi.WA.Account.Responses
{
    public class InstanceStatusResponse : InstanceStatus, IInstanceStatusResponse
    {
        #region Properties

        public string? Result { get; set; }
        public bool? Success { get; set; }
        public string? ErrorMessage { get; set; }
        public AccountStatusType? AccountStatus { get; set; }

        #endregion

        #region Methods

        public bool Equals(IInstanceStatusResponse? other)
        {
            return base.Equals(other) && 
                   
                   Result == other.Result && 
                   Success == other.Success && 
                   ErrorMessage == other.ErrorMessage && 
                   AccountStatus == other.AccountStatus;
        }

        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is IInstanceStatusResponse other && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = base.GetHashCode();
                hashCode = (hashCode * 397) ^ Success.GetHashCode();
                hashCode = (hashCode * 397) ^ (Result != null ? Result.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (ErrorMessage != null ? ErrorMessage.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (AccountStatus != null ? AccountStatus.GetHashCode() : 0);
                return hashCode;
            }
        }

        public static bool operator == (InstanceStatusResponse? left, InstanceStatusResponse? right) => EquatableHelper.IsEquatable(left, right);
        public static bool operator != (InstanceStatusResponse? left, InstanceStatusResponse? right) => !EquatableHelper.IsEquatable(left, right);
        
        #endregion
    }
}