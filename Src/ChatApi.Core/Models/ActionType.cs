using System.Runtime.Serialization;

namespace ChatApi.Core.Models
{
    /// <summary/>
    public enum ActionType : byte
    {
        /// <summary/>
        [EnumMember(Value = "create group")]
        CreateGroup = 1,

        /// <summary/>
        [EnumMember(Value = "read chat")]
        ReadDialog = 2,

        /// <summary/>
        [EnumMember(Value = "add group participant")]
        AddParticipant = 3,

        /// <summary/>
        [EnumMember(Value = "remove group participant")]
        RemoveParticipant = 4,

        /// <summary/>
        [EnumMember(Value = "promote group participant")]
        PromoteParticipant = 5,

        /// <summary/>
        [EnumMember(Value = "demote group participant")]
        DemoteParticipant = 6
    }
}
