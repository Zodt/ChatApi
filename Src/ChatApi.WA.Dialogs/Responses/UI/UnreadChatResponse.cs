using ChatApi.WA.Dialogs.Responses.UI.Interfaces;

namespace ChatApi.WA.Dialogs.Responses.UI
{
    /// <inheritdoc cref="ChatApi.WA.Dialogs.Responses.UI.Interfaces.IUnreadChatResponse" />
    public sealed record UnreadChatResponse : ChatOperationResponse, IUnreadChatResponse;
}