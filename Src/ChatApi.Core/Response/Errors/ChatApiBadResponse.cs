using System;

namespace ChatApi.Core.Response.Errors
{
    /// <inheritdoc />
    public sealed class ChatApiBadResponse<T> : ActionError<T> { internal ChatApiBadResponse(Exception? exception) : base(exception) { } }
}