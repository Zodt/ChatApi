﻿using ChatApi.WA.Account.Responses.Interfaces;

namespace ChatApi.WA.Account.Responses
{
    /// <inheritdoc cref="ChatApi.WA.Account.Responses.Interfaces.IExpiryResponse" />
    public sealed record ExpiryResponse : InstanceStatusResponse, IExpiryResponse;
}