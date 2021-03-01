using System.Runtime.Serialization;

namespace ChatApi.Core.Models
{
    //Need description:chatApi
    /// <summary/>
    public enum MessageType : byte
    {
        /// <summary/>
        NotFoundType,
        
        /// <summary/>
        [EnumMember(Value = "chat")]
        TextMessage = 1,
        
        /// <summary/>
        [EnumMember(Value = "image")]
        Image = 2,
        
        /// <summary/>
        [EnumMember(Value = "ptt")]
        Voice = 3,
        
        /// <summary/>
        [EnumMember(Value = "document")]
        Document = 4,
        
        /// <summary/>
        [EnumMember(Value = "audio")]
        Audio = 5,
        
        /// <summary/>
        [EnumMember(Value = "video")]
        Video = 6,
        
        /// <summary/>
        [EnumMember(Value = "location")]
        Location = 7,
        
        /// <summary/>
        [EnumMember(Value = "vcard")]
        Contact = 8,
        
        /// <summary/>
        [EnumMember(Value = "multi_vcard")]
        Contacts = 9,
        
        /// <summary/>
        [EnumMember(Value = "call_log")]
        CallLog = 10
    }
}