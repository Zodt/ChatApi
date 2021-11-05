using ChatApi.WA.Dialogs.Requests.UI.Interfaces;

namespace ChatApi.WA.Dialogs.Requests.UI
{
    /// <inheritdoc cref="ChatApi.WA.Dialogs.Requests.UI.Interfaces.IReadChatRequest" />
    public sealed record ReadChatRequest : ChatOperationsRequest, IReadChatRequest;
}