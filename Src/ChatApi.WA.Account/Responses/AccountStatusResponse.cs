using ChatApi.Core.Helpers;
using ChatApi.WA.Account.Models;
using ChatApi.WA.Account.Models.Interfaces;
using ChatApi.WA.Account.Responses.Interfaces;

namespace ChatApi.WA.Account.Responses
{
    public sealed class AccountStatusResponse : IAccountStatusResponse
    {
        #region Properties
        public string? QrCode { get; set; }
        public AccountStatusType? AccountStatus { get; set; }
        public IAccountStatusData? StatusData { get; set; }

        
        public bool? Success { get; set; }
        public string? Result { get; set; }
        public string? ErrorMessage { get; set; }

        #endregion

        #region Equatable

        public bool Equals(IAccountStatusResponse? other)
        {
            return other is not null &&
                AccountStatus == other.AccountStatus &&
                   ErrorMessage == other.ErrorMessage &&
                   QrCode == other.QrCode &&
                   Result == other.Result &&
                   Success == other.Success &&

                   Equals(StatusData, other.StatusData);
        }

        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is IAccountStatusResponse other && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = (QrCode is not null ? QrCode.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (AccountStatus is not null ? AccountStatus.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (StatusData is not null ? StatusData.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ Success.GetHashCode();
                hashCode = (hashCode * 397) ^ (Result is not null ? Result.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (ErrorMessage is not null ? ErrorMessage.GetHashCode() : 0);
                return hashCode;
            }
        }

        public static bool operator == (AccountStatusResponse? left, AccountStatusResponse? right) => EquatableHelper.IsEquatable(left, right);
        public static bool operator != (AccountStatusResponse? left, AccountStatusResponse? right) => !EquatableHelper.IsEquatable(left, right);

        #endregion
    }
}