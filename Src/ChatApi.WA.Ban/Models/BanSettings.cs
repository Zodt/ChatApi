using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Ban.Models.Interfaces;

namespace ChatApi.WA.Ban.Models
{
    public abstract class BanSettings : Printable, IBanSettings
    {
        #region Properties

        public bool? IsSet { get; set; }
        public string? BanPhoneMask { get; set; }
        public string? PreBanMessage { get; set; }

        #endregion

        #region Equatable

        public bool Equals(IBanSettings? other)
        {
            return other is not null && 
                   IsSet == other.IsSet &&
                   BanPhoneMask == other.BanPhoneMask && 
                   PreBanMessage == other.PreBanMessage;
        }

        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is IBanSettings self && Equals(self);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = IsSet.GetHashCode();
                hashCode = (hashCode * 397) ^ (BanPhoneMask != null ? BanPhoneMask.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (PreBanMessage != null ? PreBanMessage.GetHashCode() : 0);
                return hashCode;
            }
        }

        public static bool operator == (BanSettings? left, BanSettings? right) => EquatableHelper.IsEquatable(left, right);
        public static bool operator != (BanSettings? left, BanSettings? right) => !EquatableHelper.IsEquatable(left, right);

        #endregion
        
        #region Printable

        protected override void PrintContent(int shift)
        {
            AddMember(nameof(IsSet), IsSet, shift);
            AddMember(nameof(BanPhoneMask), BanPhoneMask, shift);
            AddMember(nameof(PreBanMessage), PreBanMessage, shift);
        }

        #endregion
    }
}