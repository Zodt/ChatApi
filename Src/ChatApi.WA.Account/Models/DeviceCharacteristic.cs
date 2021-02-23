using ChatApi.Core.Helpers;
using ChatApi.WA.Account.Models.Interfaces;

namespace ChatApi.WA.Account.Models
{
    public sealed class DeviceCharacteristic : IDeviceCharacteristic
    {
        #region Properties

        public string? OsVersion { get; set; }
        public string? Manufacturer { get; set; }
        public string? Model { get; set; }

        #endregion

        #region Equatable

        public bool Equals(IDeviceCharacteristic? other)
        {
            return other is not null && 
                OsVersion == other.OsVersion && 
                   Manufacturer == other.Manufacturer && 
                   Model == other.Model;
        }

        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is IDeviceCharacteristic other && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = (OsVersion != null ? OsVersion.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Manufacturer != null ? Manufacturer.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Model != null ? Model.GetHashCode() : 0);
                return hashCode;
            }
        }

        public static bool operator ==(DeviceCharacteristic? left, DeviceCharacteristic? right) => EquatableHelper.IsEquatable(left, right);
        public static bool operator !=(DeviceCharacteristic? left, DeviceCharacteristic? right) => !EquatableHelper.IsEquatable(left, right);
        
        #endregion        
    }
}