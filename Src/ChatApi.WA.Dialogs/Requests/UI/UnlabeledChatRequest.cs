using ChatApi.WA.Dialogs.Requests.UI.Interfaces;

namespace ChatApi.WA.Dialogs.Requests.UI
{
    /// <inheritdoc cref="ChatApi.WA.Dialogs.Requests.UI.Interfaces.IUnlabeledChatRequest" />
    public sealed record UnlabeledChatRequest : LabelOperationsRequest, IUnlabeledChatRequest { }
}