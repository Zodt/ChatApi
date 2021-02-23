using System.Runtime.Serialization;

namespace ChatApi.WA.Account.Models
{
    public enum InstanceConnectionStatusType : byte
    {
        [EnumMember(Value = "connecting")]
        Connecting = 1,
        [EnumMember(Value = "syncing")]
        Syncing = 1,
        [EnumMember(Value = "offline")]
        Offline = 1,
        [EnumMember(Value = "proxyblock")]
        ProxyBlock = 1,
        [EnumMember(Value = "conflict")]
        Conflict = 1
    }
}