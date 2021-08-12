using System.Runtime.Serialization;

namespace ChatApi.WA.Account.Models
{
    //Need description:chatApi
    /// <summary/>
    public enum InstanceStatusActionType : byte
    {
        /// <summary/>
        [EnumMember(Value = "learn_more")]
        LearnMore = 0,

        /// <summary/>
        [EnumMember(Value = "expiry")]
        Expiry = 1,

        /// <summary/>
        [EnumMember(Value = "retry")]
        Retry = 2,

        /// <summary/>
        [EnumMember(Value = "takeover")]
        Takeover = 3,

        /// <summary/>
        [EnumMember(Value = "logout")]
        Logout = 4
    }
}
