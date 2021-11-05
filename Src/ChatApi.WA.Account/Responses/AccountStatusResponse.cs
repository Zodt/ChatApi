using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Account.Models;
using ChatApi.WA.Account.Models.Interfaces;
using ChatApi.WA.Account.Responses.Interfaces;

namespace ChatApi.WA.Account.Responses
{
    /// <summary/>
    public sealed class AccountStatusResponse : Printable, IAccountStatusResponse
    {

        #region Properties

        /// <inheritdoc />
        public string? QrCode { get; set; }

        /// <inheritdoc />
        public AccountStatusType? AccountStatus { get; set; }

        /// <inheritdoc />
        public IAccountStatusData? StatusData { get; set; }


        /// <inheritdoc />
        public bool? Success { get; set; }

        /// <inheritdoc />
        public string? Result { get; set; }

        /// <inheritdoc />
        public string? ErrorMessage { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
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

        /// <inheritdoc />
        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is IAccountStatusResponse other && Equals(other);
        }

        /// <inheritdoc />
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

        /// <summary/>
        public static bool operator ==(AccountStatusResponse? left, AccountStatusResponse? right)
        {
            return EquatableHelper.IsEquatable(left, right);
        }
        /// <summary/>
        public static bool operator !=(AccountStatusResponse? left, AccountStatusResponse? right)
        {
            return !EquatableHelper.IsEquatable(left, right);
        }

        #endregion

        #region Printable

        /// <inheritdoc />
        protected override void PrintContent(int shift)
        {
            AddMember(nameof(QrCode), QrCode?.Substring(0, 20), shift);
            AddMember(nameof(StatusData), StatusData, shift);
            AddMember(nameof(AccountStatus), AccountStatus, shift);
            AddMember(nameof(Success), Success, shift);
            AddMember(nameof(Result), Result, shift);
            AddMember(nameof(ErrorMessage), ErrorMessage, shift);
        }

        #endregion

    }
}
