using System.Runtime.Serialization;

namespace ChatApi.Core.Models
{
    public enum ChatApiStatusOperation : byte
    {
        [EnumMember(Value = "error")]
        Error = 0,
        [EnumMember(Value = "success")]
        Success = 1,
        [EnumMember(Value = "created")]
        Created = 2,
        [EnumMember(Value = "deleted")]
        Deleted = 3,
        [EnumMember(Value = "exists")]
        Exists = 4,
        
    }
}