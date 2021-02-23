using System;
using Newtonsoft.Json;

namespace ChatApi.Core.Converters
{
    public class NegativeBoolConverter : JsonConverter<bool?>
    {
        public override void WriteJson(JsonWriter writer, bool? value, JsonSerializer serializer)
        {
            if (value is not null)
                writer.WriteRawValue((!value).ToString());
        }

        public override bool? ReadJson(JsonReader reader, Type objectType, bool? existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            if (reader.TokenType != JsonToken.Boolean || (bool?)reader.Value is null ) return null;

            return !(bool) reader.Value;
        }
    }
}