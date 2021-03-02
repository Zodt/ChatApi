using System.Runtime.CompilerServices;
using System.Text;
using ChatApi.Core.Models.Interfaces;

namespace ChatApi.Core.Models
{
    // Rewrite in the future
    /// <inheritdoc cref="IPrintable"/>
    public abstract class Printable : IPrintable
    {
        private const string Shift = "  ";
        private readonly StringBuilder _stringBuilder = new ();

        /// <summary>
        ///     Description of the properties contained by the class
        /// </summary>
        /// <remarks>
        ///     To describe the properties contained in the class, use the <see cref="AddMember"/>
        /// </remarks>
        /// <param name="shift">The measure of displacement of the carriage on the level of nesting</param>
        protected abstract void PrintContent(int shift);

        private void AddMember(string memberName, string? value, int shift)
        {
            if (string.IsNullOrWhiteSpace(value)) return;
            _stringBuilder.AppendLine(string.Concat(GetShift(shift), memberName, ": ", value, ","));
        }

        /*ReSharper disable once HeapView.PossibleBoxingAllocation*/
        /// <summary>
        ///     Writing data of the property for the template
        /// </summary>
        /// <param name="memberName">Name of property</param>
        /// <param name="value">Value of property</param>
        /// <param name="shift">The measure of displacement of the carriage on the level of nesting</param>
        protected void AddMember<T>(string memberName, T value, int shift) { switch (value)
        {
            case string stringValue: AddMember(memberName, stringValue, shift); return;
            case Printable printable: AddMember(memberName, printable.PrintMembers(shift), shift); return;
            default: AddMember(memberName, value?.ToString(), shift); return;
        }}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static string GetShift(int? shiftValue)
        {
            if (shiftValue is not { } value) return string.Empty;

            string shift = string.Empty;
            while (value > 0)
            {
                shift += Shift;
                value -= 1;
            }

            return shift;
        }
        
        /// <inheritdoc />
        public string PrintMembers()
        {
            int shift = default;
            _stringBuilder.AppendLine("{");
            PrintContent(++shift);
            _stringBuilder.Append(string.Concat(GetShift(--shift), "}"));
            return _stringBuilder.ToString();
        }

        /// <inheritdoc />
        public string PrintMembers(int shift)
        {
            _stringBuilder.AppendLine(GetShift(shift-1) + "{");
            PrintContent(++shift);
            _stringBuilder.Append(string.Concat(GetShift(--shift-1), "}"));
            return _stringBuilder.ToString();
        }
    }
}