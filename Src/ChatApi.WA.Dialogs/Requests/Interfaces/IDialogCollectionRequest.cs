using System;
using ChatApi.Core.Models.Interfaces;

namespace ChatApi.WA.Dialogs.Requests.Interfaces
{
    public interface IDialogCollectionRequest : IEquatable<IDialogCollectionRequest?>, IParameters
    {
        /// <summary>
        ///     Page number, starts from 0 (0 by default). Example: 1
        /// </summary>
        int Page { get; set; }

        /// <summary>
        ///     Sets length of the dialog list (0 by default). With value 0 returns all dialogs.
        /// </summary>
        int Limit { get; set; }
    }
}