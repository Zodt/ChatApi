using System.Runtime.Serialization;

namespace ChatApi.WA.Account.Models
{
    public enum InstanceStatusType : byte
    {
        [EnumMember(Value = "loading")]
        Loading = 1,
        [EnumMember(Value = "normal")]
        Online = 2,
        [EnumMember(Value = "offline")]
        Offline = 3,
        [EnumMember(Value = "expired")]
        Expired = 4,
        [EnumMember(Value = "opening")]
        Opening = 5,
        [EnumMember(Value = "pairing")]
        Pairing = 6,
        [EnumMember(Value = "timeout")]
        Timeout = 7,
        [EnumMember(Value = "computer")]
        Computer = 8,
        [EnumMember(Value = "phone")]
        Phone = 9,
        [EnumMember(Value = "battery_low_1")]
        BatteryLow = 10,
        [EnumMember(Value = "battery_low_2")]
        BatteryExtremelyLow = 11
    }
}