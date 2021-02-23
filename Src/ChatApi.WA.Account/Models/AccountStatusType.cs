using System.Runtime.Serialization;

namespace ChatApi.WA.Account.Models
{
    public enum AccountStatusType
    {
        [EnumMember(Value = "got qr code")]
        GotQrCode = 1,
        
        [EnumMember(Value = "authenticated")]
        Authenticated = 1,
        
        [EnumMember(Value = "loading")]
        Loading = 1,
        
        [EnumMember(Value = "init")]
        Init = 1,
        
        [EnumMember(Value = "not_paid")]
        NotPaid = 1,
        
    }
}