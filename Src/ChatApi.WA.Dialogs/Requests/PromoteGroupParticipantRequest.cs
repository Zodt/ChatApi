using ChatApi.WA.Dialogs.Models;
using ChatApi.WA.Dialogs.Requests.Interfaces;

namespace ChatApi.WA.Dialogs.Requests
{
    /// <inheritdoc cref="ChatApi.WA.Dialogs.Requests.Interfaces.IPromoteGroupParticipantRequest" />
    public sealed record PromoteGroupParticipantRequest : ParticipantRequest, IPromoteGroupParticipantRequest;
}