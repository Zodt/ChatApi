using ChatApi.WA.Dialogs.Requests.UI.Interfaces;

namespace ChatApi.WA.Dialogs.Requests.UI
{
    /// <inheritdoc cref="ChatApi.WA.Dialogs.Requests.UI.Interfaces.IVoiceRecordingRequest" />
    public class VoiceRecordingRequest : DialogSendStatusOperationsRequest, IVoiceRecordingRequest { }

    /// <inheritdoc cref="ChatApi.WA.Dialogs.Requests.UI.Interfaces.ITypingRequest" />
    public class TypingRequest : DialogSendStatusOperationsRequest, ITypingRequest { }
}