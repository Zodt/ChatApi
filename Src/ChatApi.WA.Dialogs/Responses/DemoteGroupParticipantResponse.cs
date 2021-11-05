using ChatApi.WA.Dialogs.Responses.Interfaces;

namespace ChatApi.WA.Dialogs.Responses
{
    /// <inheritdoc cref="ChatApi.WA.Dialogs.Responses.Interfaces.IDemoteGroupParticipantResponse" />
    public sealed record DemoteGroupParticipantResponse : GroupOperationResponse, IDemoteGroupParticipantResponse;
}