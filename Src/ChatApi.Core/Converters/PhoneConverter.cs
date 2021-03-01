using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace ChatApi.Core.Converters
{
    /// <inheritdoc />
    public class PhoneConverter : JsonConverter<string?>
    {

        /// <inheritdoc />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void WriteJson(JsonWriter writer, string? value, JsonSerializer serializer)
        {
            if (string.IsNullOrWhiteSpace(value)) return;

            writer.WriteRawValue(
                JsonConvert.SerializeObject(new Regex(@"[0-9]*")
                    .Matches(value!)
                    .Cast<Match>()
                    .Select(x => x.Value)
                    .Aggregate(string.Concat)));
        }

        /// <inheritdoc />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string? ReadJson(JsonReader reader, Type objectType, string? existingValue, 
            bool hasExistingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null || reader.Value is not string phone) return null;
            return phone;
        }
    }
}