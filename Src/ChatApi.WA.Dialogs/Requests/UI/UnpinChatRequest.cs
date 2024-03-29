﻿using ChatApi.WA.Dialogs.Requests.UI.Interfaces;

namespace ChatApi.WA.Dialogs.Requests.UI
{
    /// <inheritdoc cref="ChatApi.WA.Dialogs.Requests.UI.Interfaces.IUnpinChatRequest" />
    public sealed record UnpinChatRequest : ChatOperationsRequest, IUnpinChatRequest { }
}