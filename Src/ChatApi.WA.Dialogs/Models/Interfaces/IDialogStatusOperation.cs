using System;
using ChatApi.Core.Models.Interfaces;

namespace ChatApi.WA.Dialogs.Models.Interfaces
{
    /// <summary/>
    public interface IDialogStatusOperation : IOperationResponse, IEquatable<IDialogStatusOperation?>, IPrintable { }
}