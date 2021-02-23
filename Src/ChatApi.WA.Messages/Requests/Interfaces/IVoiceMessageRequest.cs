using System;
using Newtonsoft.Json;
using ChatApi.Core.Models.Interfaces;
using ChatApi.WA.Messages.Models.Interfaces;

namespace ChatApi.WA.Messages.Requests.Interfaces
{
    public interface IVoiceMessageRequest : IMessageRequest, IQuotedMessage, IEquatable<IVoiceMessageRequest>
    {
        /// <summary>
        ///     A link to an audio ogg-file in opus codec
        ///     Or base64 ogg-file in opus codec
        /// </summary>
        /// <example>"http://audio-opus.com/14a5ef65p5efsf"</example>
        /// <example>"data:audio/ogg;base64,..."</example>
        [JsonProperty("audio", Required = Required.Always, NullValueHandling = NullValueHandling.Ignore)]
        string? Audio { get; set; } 
    }
}