using System.Runtime.Serialization;

namespace ChatApi.Core.Models
{
    public enum MessageType : byte
    {
        NotFoundType,
        [EnumMember(Value = "chat")]
        Chat = 1,
        [EnumMember(Value = "image")]
        Image = 2,
        [EnumMember(Value = "ptt")]
        Voice = 3,
        [EnumMember(Value = "document")]
        Document = 4,
        [EnumMember(Value = "audio")]
        Audio = 5,
        [EnumMember(Value = "video")]
        Video = 6,
        [EnumMember(Value = "location")]
        Location = 7,
        [EnumMember(Value = "vcard")]
        Contact = 8,
        [EnumMember(Value = "multi_vcard")]
        Contacts = 9,
        [EnumMember(Value = "call_log")]
        CallLog = 10
    }
}