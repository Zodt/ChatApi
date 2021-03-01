using System.Runtime.Serialization;

namespace ChatApi.WA.Account.Models
{
    /// <summary/>
    public enum AccountStatusType : byte
    {
        /// <summary>
        ///     There is a QR code and you need to take a picture of it in the Whatsapp application by going to Menu -> WhatsApp Web -> Add. <br/>
        ///     QR code is valid for one minute.
        /// </summary>
        [EnumMember(Value = "got qr code")]
        GotQrCode = 1,
        
        /// <summary>
        ///     Authorization passed successfully
        /// </summary>
        [EnumMember(Value = "authenticated")]
        Authenticated = 2,
        
        /// <summary>
        ///     The system is still loading, try again in 1 minute
        /// </summary>
        [EnumMember(Value = "loading")]
        Loading = 3,
        
        /// <summary>
        ///     Initial status
        /// </summary>
        [EnumMember(Value = "init")]
        Init = 4,
        
        /// <summary>
        ///     The rate of pay for your ChatApi account
        /// </summary>
        [EnumMember(Value = "not_paid")]
        NotPaid = 5,
        
        /// <summary/>
        [EnumMember(Value = "Expiry request sent to WhatsApp")]
        ExpiryOk = 6,
        /// <summary/>
        
        [EnumMember(Value = "Expiry request not sent because substatus don't equals \"expired\"")]
        ExpiryError = 7,
        /// <summary/>
        
        [EnumMember(Value = "Takeover request sent to WhatsApp")]
        TakeoverOk = 8,
        /// <summary/>
        
        [EnumMember(Value = "Takeover request not sent because substatus don't equals \"conflict\"")]
        TakeoverError = 9,
        /// <summary/>
        
        [EnumMember(Value = "Logout request sent to WhatsApp")]
        LogoutOk = 10,
        
        /// <summary/>
        [EnumMember(Value = "Retry request sent to WhatsApp")]
        RetrySynchronizeOk = 11,
        
        /// <summary/>
        [EnumMember(Value = "Retry request not sent because reason don't equals \"syncing\"")]
        RetrySynchronizeError = 12,
        
    }
}