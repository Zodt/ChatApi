using System;
using ChatApi.Core.Models.Interfaces;
using ChatApi.WA.Dialogs.Models.Interfaces;

namespace ChatApi.WA.Dialogs.Requests.UI.Interfaces
{
    /// <summary/>
    public interface IDialogSendStatusOperationsRequest : IMessageRequest, IDialogSendStatus, IEquatable<IDialogSendStatusOperationsRequest?>, IPrintable { }
}