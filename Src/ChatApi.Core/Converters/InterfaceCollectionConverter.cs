using System;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace ChatApi.Core.Converters
{
    /// <summary/>
    public class InterfaceCollectionConverter<TClass, TInterface, TCollection> : JsonConverter<TCollection?>
        where TClass : class, TInterface
        where TInterface : IEquatable<TInterface?>
        where TCollection : Collection<TInterface?>, new()
    {
        /// <inheritdoc />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void WriteJson(JsonWriter writer, TCollection? value, JsonSerializer serializer)
        {
            writer.WriteRawValue(JsonConvert.SerializeObject(value));
        }

        /// <inheritdoc />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override TCollection? ReadJson(JsonReader reader, Type objectType, TCollection? existingValue, bool hasExistingValue,
            JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;

            Collection<TClass> value = new();
            serializer.Populate(reader, value);

            TCollection interfaces = new();
            // ReSharper disable once ForCanBeConvertedToForeach
            for (int i = 0; i < value.Count; i++) interfaces.Add(value[i]);

            return interfaces;
        }
    }
}
