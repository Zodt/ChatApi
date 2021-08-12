using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace ChatApi.Core.Converters
{
    /// <summary/>
    public class InterfacesConverter<T> : JsonConverter<T?> where T : class
    {
        /// <inheritdoc />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void WriteJson(JsonWriter writer, T? value, JsonSerializer serializer)
        {
            if (value != null) serializer.Serialize(writer, value);
        }

        /// <inheritdoc />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override T? ReadJson(JsonReader reader, Type objectType, T? existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            return serializer.Deserialize(reader, typeof(T)) as T;
        }
    }
}
