using System.Runtime.Serialization;

namespace ChatApi.Core.Models
{
    /// <summary/>
    public enum ChatApiStatusOperation : byte
    {
        /// <summary/>
        [EnumMember(Value = "error")]
        Error = 0,

        /// <summary/>
        [EnumMember(Value = "success")]
        Success = 1,
        
        /// <summary/>
        [EnumMember(Value = "created")]
        Created = 2,
        
        /// <summary/>
        [EnumMember(Value = "deleted")]
        Deleted = 3,
        
        /// <summary/>
        [EnumMember(Value = "exists")]
        Exists = 4,
        
    }
}