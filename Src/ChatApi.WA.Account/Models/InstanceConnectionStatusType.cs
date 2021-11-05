using System.Runtime.Serialization;

namespace ChatApi.WA.Account.Models
{
    //Need description:chatApi
    /// <summary/>
    public enum InstanceConnectionStatusType : byte
    {
        /// <summary/>
        [EnumMember(Value = "connecting")]
        Connecting = 1,

        /// <summary/>
        [EnumMember(Value = "syncing")]
        Syncing = 1,

        /// <summary/>
        [EnumMember(Value = "offline")]
        Offline = 1,

        /// <summary/>
        [EnumMember(Value = "proxyblock")]
        ProxyBlock = 1,

        /// <summary/>
        [EnumMember(Value = "conflict")]
        Conflict = 1
    }
}
