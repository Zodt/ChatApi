using System;

namespace ChatApi.Core.Response.Errors
{
    /// <inheritdoc />
    public class ChatApiBadResponse<T> : ActionError<T> { internal ChatApiBadResponse(Exception? exception) : base(exception) { } }
}