using ChatApi.WA.Dialogs.Requests.UI.Interfaces;

namespace ChatApi.WA.Dialogs.Requests.UI
{
    /// <inheritdoc cref="ChatApi.WA.Dialogs.Requests.UI.Interfaces.IPinChatRequest" />
    public sealed record PinChatRequest : ChatOperationsRequest, IPinChatRequest;
}