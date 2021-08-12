using System.Runtime.Serialization;

namespace ChatApi.Instances.Models
{
    /// <summary>
    ///     Type of ChatApi instance
    /// </summary>
    public enum ChatApiInstanceType : byte
    {
        /// <summary>
        ///     WhatsApp production instance type
        /// </summary>
        [EnumMember(Value = "whatsapp")]
        WhatsApp = 1,

        /// <summary>
        ///     WhatsApp development instance type
        /// </summary>
        [EnumMember(Value = "whatsapp_dev")]
        WhatsAppDev = 2,
    }
}
