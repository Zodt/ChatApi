using System;
using System.Linq;
using System.Text.RegularExpressions;
using ChatApi.Core.Collections;
using ChatApi.Core.Helpers;
using Newtonsoft.Json;

namespace ChatApi.Core.Converters
{
    public class PhoneCollectionConverter : JsonConverter<WhatsAppApiCollection<string>?>
    {
        public override void WriteJson(JsonWriter writer, WhatsAppApiCollection<string>? value, JsonSerializer serializer)
        {
            if (value is null || !value.Any()) return;
            
            for (int i = 0; i < value.Count; i++)
            {
                value[i] = new Regex(@"[0-9]*")
                    .Matches(value[i]!)
                    .Cast<Match>()
                    .Select(x => x.Value)
                    .Aggregate(string.Concat);
            } 
            
            writer.WriteRawValue(JsonConvert.SerializeObject(value));
        }

        public override WhatsAppApiCollection<string>? ReadJson(JsonReader reader, Type objectType, WhatsAppApiCollection<string>? existingValue,
            bool hasExistingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null || reader.Value is not WhatsAppApiCollection<string> phoneCollection) return null;
            return phoneCollection;
        }
    }
}