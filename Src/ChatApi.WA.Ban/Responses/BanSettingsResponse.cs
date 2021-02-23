using ChatApi.WA.Ban.Models;
using ChatApi.WA.Ban.Responses.Interfaces;

namespace ChatApi.WA.Ban.Responses
{
    public sealed class BanSettingsResponse : BanSettings, IBanSettingsResponse
    {
        public string? ErrorMessage { get; set; }
    }
}