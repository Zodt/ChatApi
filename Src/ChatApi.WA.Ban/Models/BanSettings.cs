using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Ban.Models.Interfaces;

namespace ChatApi.WA.Ban.Models
{
    /// <inheritdoc cref="ChatApi.WA.Ban.Models.Interfaces.IBanSettings" />
    public abstract class BanSettings : Printable, IBanSettings
    {
        #region Properties

        /// <inheritdoc />
        public bool? IsSet { get; set; }
        
        /// <inheritdoc />
        public string? BanPhoneMask { get; set; }
        
        /// <inheritdoc />
        public string? PreBanMessage { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(IBanSettings? other)
        {
            return other is not null && 
                   IsSet == other.IsSet &&
                   BanPhoneMask == other.BanPhoneMask && 
                   PreBanMessage == other.PreBanMessage;
        }

        /// <inheritdoc />
        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is IBanSettings self && Equals(self);
        }

        /// <inheritdoc />
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

        /// <summary/>
        public static bool operator == (BanSettings? left, BanSettings? right) => EquatableHelper.IsEquatable(left, right);
        /// <summary/>
        public static bool operator != (BanSettings? left, BanSettings? right) => !EquatableHelper.IsEquatable(left, right);

        #endregion
        
        #region Printable

        /// <inheritdoc />
        protected override void PrintContent(int shift)
        {
            AddMember(nameof(IsSet), IsSet, shift);
            AddMember(nameof(BanPhoneMask), BanPhoneMask, shift);
            AddMember(nameof(PreBanMessage), PreBanMessage, shift);
        }

        #endregion
    }
}