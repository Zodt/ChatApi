using System.Text;
using System.Runtime.CompilerServices;
using ChatApi.Core.Models.Interfaces;

namespace ChatApi.Core.Models
{
    public abstract class Printable : IPrintable
    {
        private const string Shift = "  ";
        private readonly StringBuilder _stringBuilder = new ();

        protected abstract void PrintContent(int shift);

        private void AddMember(string memberName, string? value, int shift)
        {
            if (!string.IsNullOrWhiteSpace(value))
                _stringBuilder.AppendLine(string.Concat(GetShift(shift), memberName, ": ", value));
        }

        /*ReSharper disable once HeapView.PossibleBoxingAllocation*/
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
        
        public string PrintMembers()
        {
            int shift = default;
            _stringBuilder.AppendLine("{");
            PrintContent(++shift);
            _stringBuilder.Append(string.Concat(GetShift(--shift), "}"));
            return _stringBuilder.ToString();
        }

        public string PrintMembers(int shift)
        {
            _stringBuilder.AppendLine("{");
            PrintContent(++shift);
            _stringBuilder.Append(string.Concat(GetShift(--shift), "}"));
            return _stringBuilder.ToString();
        }
    }
}