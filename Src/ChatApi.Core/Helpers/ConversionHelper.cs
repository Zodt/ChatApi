using System;
using System.Text;
using ChatApi.Core.Response.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using UnixDateTimeConverter = ChatApi.Core.Converters.UnixDateTimeConverter;

namespace ChatApi.Core.Helpers
{
    /// <summary/>
    public static class ConversionHelper
    {
        /// <summary/>
        public static string Serialize<T>(this T self, IResponseSettings? responseSettings = null) where T : class
        {
            if (self is null) throw new JsonSerializationException();

            string serialize = JsonConvert.SerializeObject(self, new JsonSerializerSettings
            {
                DefaultValueHandling = DefaultValueHandling.Ignore,
                NullValueHandling = NullValueHandling.Ignore,
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                DateParseHandling = DateParseHandling.None,
                Converters =
                {
                    new UnixDateTimeConverter { Offset = responseSettings?.TimeZoneOffset },
                    new StringEnumConverter { NamingStrategy = new SnakeCaseNamingStrategy() }
                }
            });
            return serialize;
        }

        /// <summary/>
        public static T Deserialize<T>(this string json, IResponseSettings? responseSettings = null) where T : class
        {
            if (string.IsNullOrEmpty(json)) throw new JsonReaderException();

            string encodingMessage = EncodingMessage(json, responseSettings?.Encoding);
            T deserialize = JsonConvert.DeserializeObject<T?>(encodingMessage, new JsonSerializerSettings
            {
                DefaultValueHandling = DefaultValueHandling.Ignore,
                NullValueHandling = NullValueHandling.Ignore,
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                DateParseHandling = DateParseHandling.None,
                Converters =
                {
                    new UnixDateTimeConverter { Offset = responseSettings?.TimeZoneOffset },
                    new StringEnumConverter { NamingStrategy = new SnakeCaseNamingStrategy() }
                }
            }) ?? throw new NullReferenceException();
            return deserialize;
        }

        private static string EncodingMessage(string message, Encoding? enc = null)
        {
            if (enc is null) return message;
            byte[] convert = Encoding.Convert(Encoding.UTF8, enc, enc.GetBytes(message));
            return enc.GetString(convert);
        }
    }
}