using ChatApi.WA.Dialogs.Requests.UI.Interfaces;

namespace ChatApi.WA.Dialogs.Requests.UI
{
    /// <inheritdoc cref="ChatApi.WA.Dialogs.Requests.UI.Interfaces.IUnreadChatRequest" />
    public sealed record UnreadChatRequest : ChatOperationsRequest, IUnreadChatRequest { }
}