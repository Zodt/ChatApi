using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ChatApi.Core.Converters
{
    /// <inheritdoc />
    public class UnixDateTimeConverter : DateTimeConverterBase
    {
        /// <summary>
        ///     Time-zone offset. <br/> Default: current time zone offset
        /// </summary>
        public TimeSpan? Offset { get; set; }
        private static readonly DateTime Epoch = new(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        /// <summary>
        ///     Convert a date to UTC format
        /// </summary>
        /// <param name="value">date</param>
        /// <exception cref="JsonSerializationException"></exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string? Convert(DateTime? value)
        {
            if (value is null) return null;
            
            var universalTime = TimeZoneInfo.ConvertTimeToUtc(value.Value) - Epoch;
            long seconds = (long)(universalTime.TotalMilliseconds / 1000d);

            if (seconds < 0) throw new JsonSerializationException(
                "Cannot convert date value that is before Unix epoch of 00:00:00 UTC on 1 January 1970.");

            return seconds.ToString();
        }

        /// <summary>
        ///     Convert a UTC format value to date
        /// </summary>
        /// <param name="value">UTC format value</param>
        /// <param name="offset">Time-zone offset. Default: current time zone offset</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DateTime Convert(long value, TimeSpan? offset = null)
        {
            DateTime dateTime;
            try
            {
                dateTime = Epoch.AddMilliseconds(value * 1000d);
            }
            catch (ArgumentOutOfRangeException)
            {
                dateTime = Epoch.AddMilliseconds(value);
            }
            return new DateTimeOffset(dateTime)
                .ToOffset(offset ?? TimeSpan.Zero)
                .DateTime;
        }

        /// <inheritdoc />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
            if (value is not DateTime dateTime) return;
            writer.WriteRawValue(Convert(dateTime));
        }

        /// <inheritdoc />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
        {
            if (reader.Value is null) return null;
            var firstOrDefault = serializer.Converters
                .FirstOrDefault(x => x is UnixDateTimeConverter) as UnixDateTimeConverter;
            return Convert((long) reader.Value, firstOrDefault?.Offset);
        }
    }
}