using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using ChatApi.Core.Converters;

namespace ChatApi.WA.Dialogs.Helpers
{
    internal readonly struct ChatIdSplitter
    {
        private List<string>? ChatIds { get; }
        public ChatIdSplitter(string? chatId)
        {
            if (string.IsNullOrWhiteSpace(chatId)) ChatIds = null;
            else
            {
                ChatIds = new Regex(@"\d*")
                    .Matches(chatId!)
                    .Cast<Match>()
                    .Select(x => x.Value)
                    .Where(x => !string.IsNullOrWhiteSpace(x))
                    .ToList();

                if (ChatIds!.Count != 2) ChatIds = null;
            }
        }


        public string? GetChatCreator() => ChatIds?.Any() ?? false ? string.Concat(ChatIds[0], "@c.us") : null;
        public DateTime? GetChatCreationDate()
        {
            if (!ChatIds?.Any() ?? false)
                return null;
            if (ChatIds?.Count != 2 || !long.TryParse(ChatIds[1], out var dateUtc))
                return null;
            return UnixDateTimeConverter.ConvertRead(dateUtc);
        }
    }
}