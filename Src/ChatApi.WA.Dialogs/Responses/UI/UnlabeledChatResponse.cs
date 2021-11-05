using ChatApi.WA.Dialogs.Responses.UI.Interfaces;

namespace ChatApi.WA.Dialogs.Responses.UI
{
    /// <inheritdoc cref="ChatApi.WA.Dialogs.Responses.UI.Interfaces.IUnlabeledChatResponse" />
    public sealed record UnlabeledChatResponse : ChatOperationResponse, IUnlabeledChatResponse;
}