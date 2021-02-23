using System.Runtime.Serialization;

namespace ChatApi.Instances.Models
{
    public enum ChatApiInstanceType : byte
    {
        [EnumMember(Value = "whatsapp")]
        WhatsApp = 1,
        [EnumMember(Value = "whatsapp_dev")]
        WhatsAppDev = 2,
    }
}