using ChatApi.WA.Dialogs.Responses.Interfaces;

namespace ChatApi.WA.Dialogs.Responses
{
    /// <inheritdoc cref="ChatApi.WA.Dialogs.Responses.Interfaces.IAddGroupParticipantResponse" />
    public sealed record AddGroupParticipantResponse : GroupOperationResponse, IAddGroupParticipantResponse { }
}