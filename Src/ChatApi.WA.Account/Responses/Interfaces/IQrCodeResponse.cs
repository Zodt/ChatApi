using System;
using ChatApi.Core.Models.Interfaces;

namespace ChatApi.WA.Account.Responses.Interfaces
{
    //Need description:chatApi
    /// <summary/>
    public interface IQrCodeResponse : IErrorResponse, IEquatable<IQrCodeResponse?>, IPrintable
    {
        /// <summary/>
        string? QrCodeImage { get; }
    }
}