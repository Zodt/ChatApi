using System;
using ChatApi.Core.Models.Interfaces;

namespace ChatApi.WA.Dialogs.Responses.UI.Interfaces
{
    public interface ILabelUpdateResponse : IOperationResponse, IEquatable<ILabelUpdateResponse?>, IPrintable { }
}