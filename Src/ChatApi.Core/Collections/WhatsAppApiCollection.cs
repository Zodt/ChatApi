using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.Core.Models.Interfaces;

namespace ChatApi.Core.Collections
{
    public abstract class WhatsAppApiCollection<T> : Collection<T>, IPrintableCollection, IEquatable<Collection<T>?> where T : class, IEquatable<T?>
    {
        #region Overridden collection methods

        public new void Add(T item)
        {
            if (Items.Contains(item)) return;
            base.Add(item);
        }

        #region AddRange

        public void AddRange(IEnumerable<T> enumerable)
        {
            IList<T> list = enumerable.ToList();
            // ReSharper disable once ForCanBeConvertedToForeach
            for (int i = 0; i < list.Count; i++)
                if (!Items.Contains(list[i])) 
                    base.Add(list[i]);
        }
        public void AddRange(IList<T> enumerable)
        {
            // ReSharper disable once ForCanBeConvertedToForeach
            for (int i = 0; i < enumerable.Count; i++)
                if (!Items.Contains(enumerable[i])) 
                    base.Add(enumerable[i]);
        }
        public void AddRange(ICollection<T> enumerable)
        {
            IList<T> list = enumerable.ToList();
            // ReSharper disable once ForCanBeConvertedToForeach
            for (int i = 0; i < list.Count; i++)
                if (!Items.Contains(list[i]))
                    base.Add(list[i]);
        }
        public void AddRange(IReadOnlyList<T> enumerable)
        {
            // ReSharper disable once ForCanBeConvertedToForeach
            for (int i = 0; i < enumerable.Count; i++)
                if (!Items.Contains(enumerable[i]))
                    base.Add(enumerable[i]);
        }
        public void AddRange(IReadOnlyCollection<T> enumerable)
        {
            IList<T> list = enumerable.ToList();
            // ReSharper disable once ForCanBeConvertedToForeach
            for (int i = 0; i < list.Count; i++)
                if (!Items.Contains(list[i]))
                    base.Add(list[i]);
        }

        #endregion
        

        #endregion

        #region Equatable

        public bool Equals(Collection<T>? other)
        {
            if (other is null || other.Count != Count) return false;

            if (typeof(T) == typeof(string))
            {
                // ReSharper disable once LoopCanBeConvertedToQuery
                for (int i = 0; i < other.Count; i++)
                    if (!string.Equals(this[i] as string, other[i] as string, StringComparison.Ordinal)) 
                        return false;
            }
            else
                // ReSharper disable once LoopCanBeConvertedToQuery
                for (int i = 0; i < other.Count; i++)
                    if (this[i] != other[i])
                        return false;

            return true;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                if (Count == 0) return default;
                int hashCode = this[0] is null ? 0 : this[0].GetHashCode();

                for (int i = 0; i < Count; i++)
                    hashCode = (hashCode * 397) ^ (this[i] is null ? 0 : this[i].GetHashCode());

                return hashCode;    
            }
        }

        public override bool Equals(object? obj) => ReferenceEquals(this, obj) || obj is Collection<T> self && Equals(self);
        public static bool operator == (WhatsAppApiCollection<T>? left, WhatsAppApiCollection<T>? right) => EquatableHelper.IsEquatable(left, right);
        public static bool operator != (WhatsAppApiCollection<T>? left, WhatsAppApiCollection<T>? right) => !EquatableHelper.IsEquatable(left, right);

        #endregion

        #region Printable

        private const string Shift = "  ";
        private readonly StringBuilder _stringBuilder = new ();
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static string GetShift(int? shiftValue)
        {
            if (shiftValue is not { } value || value <= 0) return string.Empty;

            var stringBuilder = new StringBuilder(value * Shift.Length);
            while (value > 0)
            {
                stringBuilder.Append(Shift);
                value -= 1;
            }

            return stringBuilder.ToString();
        }
        
        public string PrintMembers()
        {
            int shift = default;
            int maxPrint = Count >= 3 ? 3 : Count;
            _stringBuilder.AppendLine("[");

            if (Count == 0)
            {
                _stringBuilder.Append(GetShift(--shift) + "]");
                return _stringBuilder.ToString();
            }

            string currentShift = GetShift(++shift);
            if (this[0] is Printable)
                for (int i = 0; i <= maxPrint - 1; i++)
                    _stringBuilder.AppendLine(string.Concat((this[i] as Printable)!.PrintMembers(shift), ", "));
            
            else if (this[0] is string || !typeof(T).IsInterface)
                for (int i = 0; i <= maxPrint - 1; i++)
                    _stringBuilder.AppendLine(string.Concat(currentShift, this[i], ", "));

            _stringBuilder.Remove(_stringBuilder.Length - currentShift.Length - 2, currentShift.Length + 2);
            if (Count > maxPrint) _stringBuilder.Append("\n" + currentShift +"... ");
            _stringBuilder.AppendLine();
            _stringBuilder.Append("]");

            return _stringBuilder.ToString();
        }        
        public string PrintMembers(int shift)
        {
            int maxPrint = Count >= 3 ? 3 : Count;
            _stringBuilder.AppendLine("[");

            if (Count == 0)
            {
                _stringBuilder.Append(GetShift(--shift) + "]");
                return _stringBuilder.ToString();
            }

            string currentShift = GetShift(++shift);
            if (this[0] is Printable)
                for (int i = 0; i <= maxPrint - 1; i++)
                    _stringBuilder.AppendLine(string.Concat((this[i] as Printable)!.PrintMembers(shift-1), ", "));
            
            else if (this[0] is string || !typeof(T).IsInterface)   
                for (int i = 0; i <= maxPrint - 1; i++)
                    _stringBuilder.AppendLine(string.Concat(currentShift, this[i], ", "));

            _stringBuilder.Remove(_stringBuilder.Length - currentShift.Length - 2, currentShift.Length + 2);

            if (Count > maxPrint) _stringBuilder.Append("\n" + currentShift +"... ");
            _stringBuilder.AppendLine();
            _stringBuilder.Append("]");

            return _stringBuilder.ToString();
        }

        public string PrintMembers(int countElementPrint, int shift)
        {
            countElementPrint = countElementPrint > Count ? Count : countElementPrint;
            
            _stringBuilder.AppendLine(GetShift(shift - 1) + "[");

            if (Count == 0) return _stringBuilder.Append(GetShift(--shift) + "]").ToString();

            string currentShift = GetShift(++shift);
            if (this[0] is Printable)
                for (int i = 0; i <= countElementPrint - 1; i++)
                    _stringBuilder.AppendLine(string.Concat((this[i] as Printable)!.PrintMembers(shift), ", "));
            
            else if (this[0] is string || !typeof(T).IsInterface)
                for (int i = 0; i <= countElementPrint - 1; i++)
                    _stringBuilder.AppendLine(string.Concat(currentShift, this[i], ", "));

            _stringBuilder.Remove(_stringBuilder.Length - currentShift.Length - 2, currentShift.Length + 2);

            if (Count > countElementPrint) _stringBuilder.Append("\n" + currentShift +"... ");
            _stringBuilder.AppendLine();
            _stringBuilder.Append("]");
            

            return _stringBuilder.ToString();
        }

        #endregion
    }
}