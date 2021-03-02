namespace ChatApi.Core.Models.Interfaces
{
    /// <summary>
    ///     Output of class data
    /// </summary>
    public interface IPrintable
    {
        /// <summary>
        ///     Output of all of the class data
        /// </summary>
        /// <example>
        /// {
        ///    LastMessageNumber: 10587,
        ///    Messages: [
        ///    {
        ///        Id: true_17472822486@c.us_DF38E6A25B42CC8CCE57EC40F,
        ///        ChatId: 17633123456@c.us,
        ///        ChatName: +1 763 312-34-56,
        ///        Time: 23.02.2021 11:57:23,
        ///        Type: Contacts,
        ///        Body: BEGIN:VCARD|VERSION:3.0...,
        ///        Self: 0,
        ///        FromMe: True,
        ///        Author: 17633123456@c.us,
        ///        IsForwarded: 1,
        ///        MessageNumber: 10489
        ///    },
        ///    {
        ///        Id: true_17472822486@c.us_DF38E57EC40FE6AE57EC40F2,
        ///        ChatId: 17633123456@c.us,
        ///        ChatName: +1 763 312-34-56,
        ///        Time: 23.02.2021 12:02:28,
        ///        Type: TextMessage,
        ///        Body: That message was sended from `ChatApi.WA.Messages`,
        ///        Self: 0,
        ///        FromMe: True,
        ///        Author: 17633123456@c.us,
        ///        QuotedMessageId: true_17633123456@c.us_3A00F2C036324861D1AF_out,
        ///        QuotedMessageType: Contacts,
        ///        MessageNumber: 10503
        ///    }, ... ]
        ///}
        /// </example>
        string PrintMembers();
        
        /// <summary>
        ///     Output of all of the class data with shift
        /// </summary>
        /// <param name="shift">The measure of displacement of the carriage on the level of nesting</param>
        /// <example>
        /// {
        ///    LastMessageNumber: 10587,
        ///    Messages: [
        ///    {
        ///        Id: true_17472822486@c.us_DF38E6A25B42CC8CCE57EC40F,
        ///        ChatId: 17633123456@c.us,
        ///        ChatName: +1 763 312-34-56,
        ///        Time: 23.02.2021 11:57:23,
        ///        Type: Contacts,
        ///        Body: BEGIN:VCARD|VERSION:3.0...,
        ///        Self: 0,
        ///        FromMe: True,
        ///        Author: 17633123456@c.us,
        ///        IsForwarded: 1,
        ///        MessageNumber: 10489
        ///    },
        ///    {
        ///        Id: true_17472822486@c.us_DF38E57EC40FE6AE57EC40F2,
        ///        ChatId: 17633123456@c.us,
        ///        ChatName: +1 763 312-34-56,
        ///        Time: 23.02.2021 12:02:28,
        ///        Type: TextMessage,
        ///        Body: That message was sended from `ChatApi.WA.Messages`,
        ///        Self: 0,
        ///        FromMe: True,
        ///        Author: 17633123456@c.us,
        ///        QuotedMessageId: true_17633123456@c.us_3A00F2C036324861D1AF_out,
        ///        QuotedMessageType: Contacts,
        ///        MessageNumber: 10503
        ///    }, ... ]
        ///}
        /// </example>
        string PrintMembers(int shift);
    }
}