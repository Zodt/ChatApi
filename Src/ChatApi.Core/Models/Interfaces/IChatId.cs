using Newtonsoft.Json;

namespace ChatApi.Core.Models.Interfaces
{
    public interface IChatId
    {
        /// <summary>
        /// Filter messages by chatId
        /// <example>
        ///     <list type="bullet|number|table">
        ///          <listheader>
        ///              <term>chatId</term>
        ///              <description>ID of the chat from the message list</description>
        ///          </listheader>
        ///          <item>
        ///              <term>17633123456@c.us</term>
        ///              <description>For private messages</description>
        ///          </item>
        ///          <item>
        ///              <term>17680561234-1479621234@g.us</term>
        ///              <description>For the group</description>
        ///          </item>
        ///     </list>
        /// </example>
        /// </summary>
        [JsonProperty("chatId", NullValueHandling = NullValueHandling.Ignore)]
        string? ChatId { get; set; }
    }
}