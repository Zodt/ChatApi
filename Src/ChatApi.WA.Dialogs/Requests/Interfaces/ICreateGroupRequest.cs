using System;
using Newtonsoft.Json;
using ChatApi.Core.Converters;
using ChatApi.Core.Models.Interfaces;
using ChatApi.WA.Dialogs.Helpers.Collections;

namespace ChatApi.WA.Dialogs.Requests.Interfaces
{
    /// <summary>
    ///     Creates a group and sends the message to the created group.
    /// </summary>
    public interface ICreateGroupRequest : IEquatable<ICreateGroupRequest?>, IPrintable
    {
        /// <summary>
        ///     Name of the group being created
        /// </summary>
        [JsonProperty("groupName", Required = Required.Always, NullValueHandling = NullValueHandling.Ignore)]
        string? GroupName { get; set; }

        /// <summary>
        ///     Group avatar 640x640px
        /// </summary>
        /// <remarks>Base64-encoded file with mime data</remarks>
        /// <example>data:image/jpeg;base64,/9j/4AAQSkZJRgAiAQ..</example>
        [JsonProperty("avatar640", NullValueHandling = NullValueHandling.Ignore)]
        public string? Avatar { get; set; }

        /// <summary>
        ///     Group preview 96x96px
        /// </summary>
        /// <remarks>Base64-encoded file with mime data</remarks>
        /// <example>data:image/jpeg;base64,/9j/4AAQSkZJRgAiAQ..</example>
        [JsonProperty("preview96", NullValueHandling = NullValueHandling.Ignore)]
        public string? Preview { get; set; }

        /// <summary>
        ///     An array of phones starting with the country code.
        /// </summary>
        /// <remarks>
        ///     You do not need to add your number. <br/>
        ///     Required if chatIds is not set
        /// </remarks>
        /// <example>USA: [17472822486, 17472822488].</example>
        [JsonConverter(typeof(PhoneCollectionConverter))]
        [JsonProperty("phones", NullValueHandling = NullValueHandling.Ignore)]
        PhonesCollection? Phones { get; set; }

        /// <summary>
        ///     An array of new participients chatIds.
        /// </summary>
        [JsonProperty("chatIds", NullValueHandling = NullValueHandling.Ignore)]
        ChatIdsCollection? ChatIds { get; set; }

        /// <summary>
        ///     The text of the message that will be sent to the group when it is created. <br/>
        ///     If you do not set a parameter, the message will not be sent
        /// </summary>
        [JsonProperty("messageText", NullValueHandling = NullValueHandling.Ignore)]
        string? MessageText { get; set; }
    }
}