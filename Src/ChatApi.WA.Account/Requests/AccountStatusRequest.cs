using System.Text;
using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.WA.Account.Requests.Interfaces;

namespace ChatApi.WA.Account.Requests
{
    /// <summary/>
    public sealed record AccountStatusRequest : IAccountStatusRequest
    {

        #region Properties

        /// <inheritdoc />
        public string Parameters
        {
            get
            {
                StringBuilder stringBuilder = new();
                if (GetFullInformation is not null)
                {
                    stringBuilder.Append("&full=");
                    stringBuilder.Append(GetFullInformation);
                }

                if (NoWakeup is not null)
                {
                    stringBuilder.Append("&no_wakeup=");
                    stringBuilder.Append(NoWakeup);
                }

                return stringBuilder.ToString();
            }
        }

        /// <inheritdoc />
        public bool? NoWakeup { get; set; }

        /// <inheritdoc />
        public bool? GetFullInformation { get; set; }

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(IAccountStatusRequest? other)
        {
            return other is not null &&
                   NoWakeup == other.NoWakeup &&
                   GetFullInformation == other.GetFullInformation;
        }

        #endregion

    }
}
