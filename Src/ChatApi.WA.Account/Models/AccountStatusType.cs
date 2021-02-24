using System.Runtime.Serialization;

namespace ChatApi.WA.Account.Models
{
    public enum AccountStatusType
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
        
    }
}