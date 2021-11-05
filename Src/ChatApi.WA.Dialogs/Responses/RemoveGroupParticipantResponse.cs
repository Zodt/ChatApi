using ChatApi.WA.Dialogs.Responses.Interfaces;

namespace ChatApi.WA.Dialogs.Responses
{
    /// <inheritdoc cref="ChatApi.WA.Dialogs.Responses.Interfaces.IRemoveGroupParticipantResponse" />
    public sealed record RemoveGroupParticipantResponse : GroupOperationResponse, IRemoveGroupParticipantResponse;
}