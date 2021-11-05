using ChatApi.WA.Dialogs.Models;
using ChatApi.WA.Dialogs.Responses.UI.Interfaces;

namespace ChatApi.WA.Dialogs.Responses.UI
{
    /// <inheritdoc cref="ChatApi.WA.Dialogs.Responses.UI.Interfaces.ITypingResponse" />
    public sealed record TypingResponse : DialogStatusOperation, ITypingResponse;
}