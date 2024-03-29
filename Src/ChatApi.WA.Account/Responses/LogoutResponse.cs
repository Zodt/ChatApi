﻿using ChatApi.WA.Account.Responses.Interfaces;

namespace ChatApi.WA.Account.Responses
{
    /// <inheritdoc cref="ChatApi.WA.Account.Responses.Interfaces.ILogoutResponse" />
    public sealed record LogoutResponse : InstanceStatusResponse, ILogoutResponse;
}