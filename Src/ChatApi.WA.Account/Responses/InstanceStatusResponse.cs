using ChatApi.Core.Helpers;
using ChatApi.WA.Account.Models;
using ChatApi.WA.Account.Responses.Interfaces;

namespace ChatApi.WA.Account.Responses
{
    /// <inheritdoc cref="ChatApi.WA.Account.Responses.Interfaces.IInstanceStatusResponse" />
    public class InstanceStatusResponse : InstanceStatus, IInstanceStatusResponse
    {
        #region Properties

        /// <inheritdoc />
        public string? Result { get; set; }
        /// <inheritdoc />
        public bool? Success { get; set; }
        /// <inheritdoc />
        public string? ErrorMessage { get; set; }
        /// <inheritdoc />
        public AccountStatusType? AccountStatus { get; set; }

        #endregion

        #region Methods

        /// <inheritdoc />
        public bool Equals(IInstanceStatusResponse? other)
        {
            return base.Equals(other) && 
                   
                   Result == other!.Result && 
                   Success == other.Success && 
                   ErrorMessage == other.ErrorMessage && 
                   AccountStatus == other.AccountStatus;
        }

        /// <inheritdoc />
        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is IInstanceStatusResponse other && Equals(other);
        }

        /// <inheritdoc />
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

        /// <summary/>
        public static bool operator == (InstanceStatusResponse? left, InstanceStatusResponse? right) => EquatableHelper.IsEquatable(left, right);
        /// <summary/>
        public static bool operator != (InstanceStatusResponse? left, InstanceStatusResponse? right) => !EquatableHelper.IsEquatable(left, right);
        
        #endregion

        #region Printable

        /// <inheritdoc />
        protected override void PrintContent(int shift)
        {
            AddMember(nameof(AccountStatus), AccountStatus, shift);
            base.PrintContent(shift);
            AddMember(nameof(Result), Result, shift);
            AddMember(nameof(Success), Success, shift);
            AddMember(nameof(ErrorMessage), ErrorMessage, shift);
        }

        #endregion
    }
}