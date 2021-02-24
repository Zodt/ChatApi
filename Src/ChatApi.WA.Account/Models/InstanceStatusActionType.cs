using System.Runtime.Serialization;

namespace ChatApi.WA.Account.Models
{
    public enum InstanceStatusActionType : byte
    {
        [EnumMember(Value = "learn_more")]
        LearnMore = 0,
        [EnumMember(Value = "expiry")]
        Expiry = 1,
        [EnumMember(Value = "retry")]
        Retry = 2,
        [EnumMember(Value = "takeover")]
        Takeover = 3,
        [EnumMember(Value = "logout")]
        Logout = 4
    }
}