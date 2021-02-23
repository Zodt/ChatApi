using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Ban.Responses.Interfaces;

namespace ChatApi.WA.Ban.Responses
{
    public sealed class CheckBanResponse : Printable, ICheckBanResponse
    {
        #region Properties

        public string? Phone { get; set; }
        public bool? IsBanned { get; set; }
        public string? Message { get; set; }
        public string? BanPhoneMask { get; set; }
        public string? ErrorMessage { get; set; }


        #endregion

        #region Equatable

        public bool Equals(ICheckBanResponse? other)
        {
            return other is not null && 
                   ErrorMessage == other.ErrorMessage && 
                   Phone == other.Phone && 
                   IsBanned == other.IsBanned && 
                   Message == other.Message && 
                   BanPhoneMask == other.BanPhoneMask;
        }

        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is ICheckBanResponse other && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = IsBanned.GetHashCode();
                hashCode = (hashCode * 397) ^ (Phone != null ? Phone.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Message != null ? Message.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (BanPhoneMask != null ? BanPhoneMask.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (ErrorMessage != null ? ErrorMessage.GetHashCode() : 0);
                return hashCode;
            }
        }

        public static bool operator == (CheckBanResponse? left, CheckBanResponse? right) => EquatableHelper.IsEquatable(left, right);
        public static bool operator != (CheckBanResponse? left, CheckBanResponse? right) => !EquatableHelper.IsEquatable(left, right);

        #endregion
        
        #region Printable

        protected override void PrintContent(int shift)
        {
            AddMember(nameof(Phone), Phone, shift);
            AddMember(nameof(IsBanned), IsBanned, shift);
            AddMember(nameof(Message), Message, shift);
            AddMember(nameof(BanPhoneMask), BanPhoneMask, shift);
            AddMember(nameof(ErrorMessage), ErrorMessage, shift);
        }

        #endregion
    }
}