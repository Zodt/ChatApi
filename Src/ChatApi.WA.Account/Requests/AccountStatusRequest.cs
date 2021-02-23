using System.Text;
using ChatApi.Core.Helpers;
using ChatApi.WA.Account.Requests.Interfaces;

namespace ChatApi.WA.Account.Requests
{
    public class AccountStatusRequest : IAccountStatusRequest
    {
        public string Parameters
        {
            get
            {
                StringBuilder stringBuilder = new();
                if (GetFullInformation is not null)
                {
                    stringBuilder.Append("&full=");
                    stringBuilder.Append(GetFullInformation);                    
                }

                if (NoWakeup is not null)
                {
                    stringBuilder.Append("&no_wakeup=");
                    stringBuilder.Append(NoWakeup);
                }
                
                return stringBuilder.ToString();
            }
        }

        public bool? NoWakeup { get; set; }
        public bool? GetFullInformation { get; set; }

        public bool Equals(IAccountStatusRequest? other)
        {
            return other is not null && 
                   NoWakeup == other.NoWakeup && 
                   GetFullInformation == other.GetFullInformation;
        }

        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is IAccountStatusRequest other && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = Parameters.GetHashCode();
                hashCode = (hashCode * 397) ^ NoWakeup.GetHashCode();
                hashCode = (hashCode * 397) ^ GetFullInformation.GetHashCode();
                return hashCode;
            }
        }

        public static bool operator == (AccountStatusRequest? left, AccountStatusRequest? right) => EquatableHelper.IsEquatable(left, right);
        public static bool operator != (AccountStatusRequest? left, AccountStatusRequest? right) => !EquatableHelper.IsEquatable(left, right);
    }
}