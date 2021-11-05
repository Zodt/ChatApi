using ChatApi.WA.Dialogs.Responses.Interfaces;

namespace ChatApi.WA.Dialogs.Responses
{
    /// <inheritdoc cref="ChatApi.WA.Dialogs.Responses.Interfaces.IPromoteGroupParticipantResponse" />
    public sealed record PromoteGroupParticipantResponse : GroupOperationResponse, IPromoteGroupParticipantResponse;
}