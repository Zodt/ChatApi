using ChatApi.WA.Dialogs.Models;
using ChatApi.WA.Dialogs.Requests.Interfaces;

namespace ChatApi.WA.Dialogs.Requests
{
    /// <inheritdoc cref="ChatApi.WA.Dialogs.Requests.Interfaces.IDemoteGroupParticipantRequest" />
    public class DemoteGroupParticipantRequest : ParticipantRequest, IDemoteGroupParticipantRequest { }
}