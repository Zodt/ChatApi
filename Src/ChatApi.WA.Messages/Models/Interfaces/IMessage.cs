using System;
using ChatApi.Core.Converters;
using ChatApi.Core.Models;
using ChatApi.Core.Models.Interfaces;
using Newtonsoft.Json;

namespace ChatApi.WA.Messages.Models.Interfaces
{
    /// <summary/>
    public interface IMessage : IChatId, IEquatable<IMessage?>, IPrintable
    {
        /// <summary>
        ///     Unique id of the message
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        string? Id { get; set; }

        /// <summary>
        ///     Text message for type "chat", or link to download the file for "ptt", "image", "audio",
        ///     "video" and "document", or latitude and longitude for "location", or message "[Call]" for "call_log"
        /// </summary>
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        string? Body { get; set; }

        /// <summary>
        ///     Type of the message
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        MessageType? Type { get; set; }

        /// <summary>
        ///     Sender name
        /// </summary>
        [JsonProperty("senderName", NullValueHandling = NullValueHandling.Ignore)]
        string? SenderName { get; set; }

        /// <example>
        ///     True - outgoing, False - incoming
        /// </example>
        [JsonProperty("fromMe", NullValueHandling = NullValueHandling.Ignore)]
        bool? FromMe { get; set; }

        /// <summary>
        ///     Author ID of the message, useful for groups
        /// </summary>
        [JsonConverter(typeof(PhoneConverter))]
        [JsonProperty("author", NullValueHandling = NullValueHandling.Ignore)]
        string? Author { get; set; }

        /// <summary>
        ///     Send time, unix timestamp
        /// </summary>
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        DateTime? Time { get; set; }

        /// <summary>
        ///     Sequence number of the message in the WhatsApp database
        /// </summary>
        [JsonProperty("messageNumber", NullValueHandling = NullValueHandling.Ignore)]
        int? MessageNumber { get; set; }

        /// <summary>
        ///     null - message from another account, 1 - message from that account
        /// </summary>
        [JsonProperty("self", NullValueHandling = NullValueHandling.Ignore)]
        int? Self { get; set; }

        /// <summary>
        ///     null - not forwarded, else count of forwarded
        /// </summary>
        [JsonProperty("isForwarded", NullValueHandling = NullValueHandling.Ignore)]
        int? IsForwarded { get; set; }

        /// <summary>
        ///     Quoted message id
        /// </summary>
        [JsonProperty("quotedMsgId", NullValueHandling = NullValueHandling.Ignore)]
        string? QuotedMessageId { get; set; }

        /// <summary>
        ///     Quoted message body
        /// </summary>
        [JsonProperty("quotedMsgBody", NullValueHandling = NullValueHandling.Ignore)]
        string? QuotedMessageBody { get; set; }

        /// <summary>
        ///     Quoted message type
        /// </summary>
        [JsonProperty("quotedMsgType", NullValueHandling = NullValueHandling.Ignore)]
        MessageType? QuotedMessageType { get; set; }

        /// <summary>
        ///     Chat Name
        /// </summary>
        [JsonProperty("chatName", NullValueHandling = NullValueHandling.Ignore)]
        string? ChatName { get; set; }
    }
}
