using System;

namespace ChatApi.Core.Response.Errors
{
    public class WhatsAppResultError<T> : ActionError<T> { internal WhatsAppResultError(Exception? exception) : base(exception) { } }
}