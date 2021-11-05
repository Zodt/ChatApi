using ChatApi.WA.Account.Responses.Interfaces;

namespace ChatApi.WA.Account.Responses
{
    /// <inheritdoc cref="ChatApi.WA.Account.Responses.Interfaces.ITakeoverResponse" />
    public sealed record TakeoverResponse : InstanceStatusResponse, ITakeoverResponse;
}