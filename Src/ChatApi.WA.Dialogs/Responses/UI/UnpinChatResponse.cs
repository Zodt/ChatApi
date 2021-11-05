using ChatApi.WA.Dialogs.Responses.UI.Interfaces;

namespace ChatApi.WA.Dialogs.Responses.UI
{
    /// <inheritdoc cref="ChatApi.WA.Dialogs.Responses.UI.Interfaces.IUnpinChatResponse" />
    public sealed record UnpinChatResponse : ChatOperationResponse, IUnpinChatResponse;
}