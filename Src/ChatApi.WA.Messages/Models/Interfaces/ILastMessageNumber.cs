using Newtonsoft.Json;

namespace ChatApi.WA.Messages.Models.Interfaces
{
    /// <summary/>
    public interface ILastMessageNumber
    {
        /// <summary>
        ///     The lastMessageNumber parameter from the last response
        /// </summary>
        [JsonProperty("lastMessageNumber", NullValueHandling = NullValueHandling.Ignore)]
        int? LastMessageNumber { get; set; }    
    }
}