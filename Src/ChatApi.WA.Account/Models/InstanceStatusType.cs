using System.Runtime.Serialization;

namespace ChatApi.WA.Account.Models
{
    //Need description:chatApi
    /// <summary/>
    public enum InstanceStatusType : byte
    {
        /// <summary/>
        [EnumMember(Value = "loading")]
        Loading = 1,

        /// <summary/>
        [EnumMember(Value = "normal")]
        Online = 2,
        
        /// <summary/>
        [EnumMember(Value = "offline")]
        Offline = 3,
        
        /// <summary/>
        [EnumMember(Value = "expired")]
        Expired = 4,
        
        /// <summary/>
        [EnumMember(Value = "opening")]
        Opening = 5,
        
        /// <summary/>
        [EnumMember(Value = "pairing")]
        Pairing = 6,
        
        /// <summary/>
        [EnumMember(Value = "timeout")]
        Timeout = 7,
        
        /// <summary/>
        [EnumMember(Value = "computer")]
        Computer = 8,
        
        /// <summary/>
        [EnumMember(Value = "phone")]
        Phone = 9,
        
        /// <summary/>
        [EnumMember(Value = "battery_low_1")]
        BatteryLow = 10,
        
        /// <summary/>
        [EnumMember(Value = "battery_low_2")]
        BatteryExtremelyLow = 11
    }
}