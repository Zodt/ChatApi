﻿using ChatApi.WA.Account.Models;
using ChatApi.WA.Account.Requests.Interfaces;

namespace ChatApi.WA.Account.Requests
{
    /// <summary/>
    public sealed record AccountSettingsRequest : AccountSettings, IAccountSettingsRequest;
}