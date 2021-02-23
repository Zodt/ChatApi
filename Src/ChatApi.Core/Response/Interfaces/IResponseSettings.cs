using System;
using System.Text;
using ChatApi.Core.Models;

namespace ChatApi.Core.Response.Interfaces
{
    public interface IResponseSettings
    {
        /// <summary>
        ///     Using the old or new server interaction
        /// </summary>
        bool IsNewSchema { get; set; }

        /// <summary>
        ///     Chat-api's response message encoding
        /// </summary>
        /// <remarks>
        ///     By default, Chat-api use <b>utf-8</b> encoding
        /// </remarks>
        Encoding Encoding { get; set; }

        /// <summary>
        ///     Http or Https protocol
        /// </summary>
        Protocol TypeProtocol { get; set; }
        /// <summary>
        ///     Time zone offset
        /// </summary>
        /// <remarks><b>Offset must be specified in whole minutes</b></remarks>
        TimeSpan TimeZoneOffset { get; set; }
    }
}