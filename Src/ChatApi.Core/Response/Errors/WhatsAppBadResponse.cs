using System;

namespace ChatApi.Core.Response.Errors
{
    public class WhatsAppBadResponse<T> : ActionError<T> { internal WhatsAppBadResponse(Exception? exception) : base(exception) { } }
}