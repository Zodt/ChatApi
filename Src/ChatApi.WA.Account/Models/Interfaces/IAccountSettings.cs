using System;
using Newtonsoft.Json;
using ChatApi.Core.Models.Interfaces;

namespace ChatApi.WA.Account.Models.Interfaces
{
    public interface IAccountSettings : IErrorResponse, IEquatable<IAccountSettings?>, IPrintable
    {
        
        /// <summary>
        ///     Delay in seconds between receive request and sending message.
        /// </summary>
        [JsonProperty("sendDelay", NullValueHandling = NullValueHandling.Ignore)]
        int? SendDelay { get; set; } 

        /// <summary>
        ///     Http or https URL for receiving notifications.
        /// </summary>
        /// <remarks> For testing, we recommend using RequestBin - http://bin.chat-api.com/?_ga=2.77776532.1025963245.1612363999-391093691.1599248612</remarks>
        [JsonProperty("webhookUrl", NullValueHandling = NullValueHandling.Ignore)]
        string? WebhookUrl { get; set; } 

        /// <summary>
        ///     Turn on/off collecting instance status changing history.
        /// </summary>
        [JsonProperty("instanceStatuses", NullValueHandling = NullValueHandling.Ignore)]
        bool? InstanceStatuses { get; set; } 

        /// <summary>
        ///     Turn on/off collecting messages webhooks statuses.
        /// </summary>
        [JsonProperty("webhookStatuses", NullValueHandling = NullValueHandling.Ignore)]
        bool? WebhookStatuses { get; set; } 

        /// <summary>
        ///     Turn on/off instance changing status notifications in webhooks.
        /// </summary>
        [JsonProperty("statusNotificationsOn", NullValueHandling = NullValueHandling.Ignore)]
        bool? StatusNotificationsOn { get; set; } 

        /// <summary>
        ///     Turn on/off ack (message delivered and message viewed) notifications in webhooks.
        /// </summary>
        /// <remarks>GET method works for the same address.</remarks>
        [JsonProperty("ackNotificationsOn", NullValueHandling = NullValueHandling.Ignore)]
        bool? AckNotificationsOn { get; set; } 

        /// <summary>
        ///     Turn on/off chat update notifications in webhooks.
        /// </summary>
        /// <remarks>GET method works for the same address.</remarks>
        [JsonProperty("chatUpdateOn", NullValueHandling = NullValueHandling.Ignore)]
        bool? ChatUpdateOn { get; set; } 

        /// <summary>
        ///     Turn on/off receiving video messages.
        /// </summary>
        [JsonProperty("videoUploadOn", NullValueHandling = NullValueHandling.Ignore)]
        bool? VideoUploadOn { get; set; } 

        /// <summary>
        ///     Socks5 IP address and port proxy for instance.
        /// </summary>
        [JsonProperty("proxy", NullValueHandling = NullValueHandling.Ignore)]
        string? Proxy { get; set; } 

        /// <summary>
        ///     Guarantee webhook delivery. Each webhook will make 20 attempts to send until it receives 200 status from the server.
        /// </summary>
        [JsonProperty("guaranteedHooks", NullValueHandling = NullValueHandling.Ignore)]
        bool? GuaranteedHooks { get; set; } 

        /// <summary>
        ///     Do not send webhooks with old messages (receiver 5 minutes or oldMessagesPeriod seconds later).
        /// </summary>
        [JsonProperty("ignoreOldMessages", NullValueHandling = NullValueHandling.Ignore)]
        bool? IgnoreOldMessages { get; set; } 

        /// <summary>
        ///     The period in seconds after which the message is considered old.
        /// </summary>
        [JsonProperty("oldMessagesPeriod", DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore)]
        int? OldMessagesPeriod { get; set; } 

        /// <summary>
        ///     Process messages from archived chats.   
        /// </summary>
        [JsonProperty("processArchive", NullValueHandling = NullValueHandling.Ignore)]
        bool? ProcessArchive { get; set; } 

        /// <summary>
        ///     Turn on/off dialogs archiving (can slow down instance).
        /// </summary>
        [JsonProperty("disableDialogsArchive", NullValueHandling = NullValueHandling.Ignore)]
        bool? DisableDialogsArchive { get; set; } 

        /// <summary>
        ///     Turn on/off parallel webhook sending.
        /// </summary>
        [JsonProperty("parallelHooks", NullValueHandling = NullValueHandling.Ignore)]
        bool? ParallelHooks { get; set; } 
    }
}