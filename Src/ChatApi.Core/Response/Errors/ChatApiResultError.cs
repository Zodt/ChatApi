using System;

namespace ChatApi.Core.Response.Errors
{
    /// <inheritdoc />
    public sealed class ChatApiResultError<T> : ActionError<T> { internal ChatApiResultError(Exception? exception) : base(exception) { } }
}