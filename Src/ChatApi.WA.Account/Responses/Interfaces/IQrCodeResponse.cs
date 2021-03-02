using System;
using ChatApi.Core.Models.Interfaces;

namespace ChatApi.WA.Account.Responses.Interfaces
{
    /// <summary/>
    public interface IQrCodeResponse : IErrorResponse, IEquatable<IQrCodeResponse?>, IPrintable
    {
        /// <summary>
        ///     Image of the QR code in PNG format
        /// </summary>
        string? QrCodeImage { get; }
    }
}