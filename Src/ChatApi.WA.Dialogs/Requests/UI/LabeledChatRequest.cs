using ChatApi.WA.Dialogs.Requests.UI.Interfaces;

namespace ChatApi.WA.Dialogs.Requests.UI
{
    /// <inheritdoc cref="ChatApi.WA.Dialogs.Requests.UI.Interfaces.ILabeledChatRequest" />
    public sealed record LabeledChatRequest : LabelOperationsRequest, ILabeledChatRequest { }
}