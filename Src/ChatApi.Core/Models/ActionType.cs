using System.Runtime.Serialization;

namespace ChatApi.Core.Models
{
    public enum ActionType : byte
    {
        [EnumMember(Value = "create group")]
        CreateGroup = 1,
        [EnumMember(Value = "read chat")]
        ReadDialog = 2,
        [EnumMember(Value = "add group participant")]
        AddParticipant = 3,
        [EnumMember(Value = "remove group participant")]
        RemoveParticipant = 4,
        [EnumMember(Value = "promote group participant")]
        PromoteParticipant = 5,
        [EnumMember(Value = "demote group participant")]
        DemoteParticipant = 6
    }
}