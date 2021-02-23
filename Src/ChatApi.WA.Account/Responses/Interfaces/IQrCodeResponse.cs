using System;
using ChatApi.Core.Models.Interfaces;

namespace ChatApi.WA.Account.Responses.Interfaces
{
    public interface IQrCodeResponse : IErrorResponse, IEquatable<IQrCodeResponse?>
    {
        string? QrCodeImage { get; set; }
    }
}