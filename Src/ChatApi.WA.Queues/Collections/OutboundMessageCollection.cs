﻿using ChatApi.Core.Collections;
using ChatApi.Core.Helpers;
using ChatApi.WA.Queues.Responses.Interfaces;

namespace ChatApi.WA.Queues.Collections
{
    public sealed class OutboundMessageCollection : WhatsAppApiCollection<IMessageQueue> { }
}