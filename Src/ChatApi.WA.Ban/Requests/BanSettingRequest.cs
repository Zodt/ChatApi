using ChatApi.WA.Ban.Models;
using ChatApi.WA.Ban.Requests.Interfaces;

namespace ChatApi.WA.Ban.Requests
{
    /// <inheritdoc cref="ChatApi.WA.Ban.Requests.Interfaces.IBanSettingsRequest" />
    public sealed record BanSettingRequest : BanSettings, IBanSettingsRequest;
}