using System.Text;
using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Account.Requests.Interfaces;

namespace ChatApi.WA.Account.Requests
{
    /// <summary/>
    public class AccountStatusRequest : Printable, IAccountStatusRequest
    {
        #region Properties

        /// <inheritdoc />
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

        /// <inheritdoc />
        public bool? NoWakeup { get; set; }
        /// <inheritdoc />
        public bool? GetFullInformation { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(IAccountStatusRequest? other)
        {
            return other is not null && 
                   NoWakeup == other.NoWakeup && 
                   GetFullInformation == other.GetFullInformation;
        }

        /// <inheritdoc />
        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is IAccountStatusRequest other && Equals(other);
        }

        /// <inheritdoc />
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

        /// <summary/>
        public static bool operator == (AccountStatusRequest? left, AccountStatusRequest? right) => EquatableHelper.IsEquatable(left, right);
        /// <summary/>
        public static bool operator != (AccountStatusRequest? left, AccountStatusRequest? right) => !EquatableHelper.IsEquatable(left, right);

        #endregion

        #region Printable

        /// <inheritdoc />
        protected override void PrintContent(int shift)
        {
            AddMember(nameof(NoWakeup), NoWakeup, shift);
            AddMember(nameof(GetFullInformation), GetFullInformation, shift);
        }

        #endregion
    }
}