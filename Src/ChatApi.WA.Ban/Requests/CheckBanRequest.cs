using ChatApi.Core.Helpers;
using ChatApi.WA.Ban.Requests.Interfaces;

namespace ChatApi.WA.Ban.Requests
{
    public class CheckBanRequest : ICheckBanRequest
    {
        public string? Phone { get; set; }

        public bool Equals(ICheckBanRequest? other)
        {
            return other is not null && 
                Phone == other.Phone;
        }

        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is ICheckBanRequest self && Equals(self);
        }

        public override int GetHashCode()
        {
            return Phone != null ? Phone.GetHashCode() : 0;
        }

        public static bool operator == (CheckBanRequest? left, CheckBanRequest? right) => EquatableHelper.IsEquatable(left, right);
        public static bool operator != (CheckBanRequest? left, CheckBanRequest? right) => !EquatableHelper.IsEquatable(left, right);
    }
}