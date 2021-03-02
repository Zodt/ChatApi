# ChatApi.WA.Dialogs [![NuGet version (ChatApi.WA.Dialogs)](../../../../Images/NuGetVersions/ChatApi.WA.Dialogs_NuGetVersion.png)](https://www.nuget.org/packages/ChatApi.WA.Dialogs/)
`ChatApi.WA.Dialogs` allows you to work with dialogs (personal chats and groups).

### Table of contents

1.  **Operations with dialogs**
    1.  [`Getting information about the dialog.`](DialogOperations/GetDialog.md)
    2.  [`Getting a dialogs`](DialogOperations/GetDialogs.md)
    3.  [`Removing the dialog`](DialogOperations/RemoveDialog.md)

2.  **Operations with groups**
    1. [`Creating the group`](GroupOperations/CreateGroup.md)
    2. [`Joining the group`](GroupOperations/JoinGroup.md)
    3. [`Leaving the group`](GroupOperations/LeaveGroup.md)
    4. `Participant Operations`
        1. [`Adding a participant to the group.`](GroupOperations/ParticipantOperations/AddParticipant.md)
        2. [`Removing a participant from a group.`](GroupOperations/ParticipantOperations/RemoveParticipant.md)
        3. [`The appointment of a participant of the administrator group.`](GroupOperations/ParticipantOperations/PromoteParticipant.md)
        4. [`Depriving a participant of the group administration rights.`](GroupOperations/ParticipantOperations/DemoteParticipant.md)

3.  **Operations with user interface**
    1.  [`Mark dialog as "pinned".`](UIOperations/PinChat.md)
    2.  [`Mark dialog as "read"`](UIOperations/ReadChat.md)
    3.  [`Mark dialog as "unread"`](UIOperations/UnReadChat.md)
    4.  [`Removes the "pinned" mark.`](UIOperations/UnpinChat.md)
    5.  [`Send "Typing" status to dialog.`](UIOperations/SendTypingStatus.md)
    6.  [`Send "Recording" status to dialog.`](UIOperations/SendVoiceRecordingStatus.md)
    
4. **Operations with only WhatsApp Business** 
    1.  [`Creating the label.`](WhatsAppBusinessOperations/CreateLabel.md)
    2.  [`Removing the label.`](WhatsAppBusinessOperations/RemoveLabel.md)
    3.  [`Changing the shortcut settings.`](WhatsAppBusinessOperations/UpdateLabel.md)
    4.  [`Getting the collection of a labels.`](WhatsAppBusinessOperations/GetLabels.md)
    5.  [`Add the label to the dialog.`](WhatsAppBusinessOperations/LabeledChat.md)
    6.  [`Remove the label from the dialog.`](WhatsAppBusinessOperations/UnlabeledChat.md)