using ChatApi.WA.Ban.Models;
using ChatApi.WA.Ban.Responses.Interfaces;

namespace ChatApi.WA.Ban.Responses
{
    /// <inheritdoc cref="ChatApi.WA.Ban.Responses.Interfaces.IBanSettingsResponse" />
    public sealed class BanSettingsResponse : BanSettings, IBanSettingsResponse
    {
        /// <inheritdoc />
        public string? ErrorMessage { get; set; }
    }
}