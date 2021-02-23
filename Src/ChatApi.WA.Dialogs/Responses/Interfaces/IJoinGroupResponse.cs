using System;
using ChatApi.Core.Models.Interfaces;

namespace ChatApi.WA.Dialogs.Responses.Interfaces
{
    public interface IJoinGroupResponse : IChatId, IErrorResponse, IEquatable<IJoinGroupResponse?>, IPrintable { }

}