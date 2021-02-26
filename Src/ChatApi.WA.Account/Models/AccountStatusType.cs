using System.Runtime.Serialization;

namespace ChatApi.WA.Account.Models
{
    public enum AccountStatusType : byte
    {
        [EnumMember(Value = "got qr code")]
        GotQrCode = 1,
        
        [EnumMember(Value = "authenticated")]
        Authenticated = 2,
        
        [EnumMember(Value = "loading")]
        Loading = 3,
        
        [EnumMember(Value = "init")]
        Init = 4,
        
        [EnumMember(Value = "not_paid")]
        NotPaid = 5,
        
        [EnumMember(Value = "Expiry request sent to WhatsApp")]
        ExpiryOk = 6,
        
        [EnumMember(Value = "Expiry request not sent because substatus don't equals \"expired\"")]
        ExpiryError = 7,
        
        [EnumMember(Value = "Takeover request sent to WhatsApp")]
        TakeoverOk = 8,
        
        [EnumMember(Value = "Takeover request not sent because substatus don't equals \"conflict\"")]
        TakeoverError = 9,
        
        [EnumMember(Value = "Logout request sent to WhatsApp")]
        LogoutOk = 10,
        
        [EnumMember(Value = "Retry request sent to WhatsApp")]
        RetrySynchronizeOk = 11,
        
        [EnumMember(Value = "Retry request not sent because reason don't equals \"syncing\"")]
        RetrySynchronizeError = 12,
        
    }
}