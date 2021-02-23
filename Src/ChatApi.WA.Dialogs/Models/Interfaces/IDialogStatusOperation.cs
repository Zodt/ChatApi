using System;
using ChatApi.Core.Models.Interfaces;

namespace ChatApi.WA.Dialogs.Models.Interfaces
{
    public interface IDialogStatusOperation : IOperationResponse, IEquatable<IDialogStatusOperation?>, IPrintable { }
}