using ChatApi.WA.Dialogs.Requests.UI.Interfaces;

namespace ChatApi.WA.Dialogs.Requests.UI
{
    public class VoiceRecordingRequest : DialogSendStatusOperationsRequest, IVoiceRecordingRequest { }
    public class TypingRequest : DialogSendStatusOperationsRequest, ITypingRequest { }
}