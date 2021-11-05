using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using ChatApi.Core.Helpers;
using ChatApi.Core.Models;
using ChatApi.Core.Models.Interfaces;

// ReSharper disable LoopCanBeConvertedToQuery
namespace ChatApi.Core.Collections
{
    /// <summary>Provides the base class for a generic WhatsApp-collection.</summary>
    /// <typeparam name="T">The type of elements in the collection.</typeparam>
    public abstract class WhatsAppApiCollection<T> : Collection<T?>, IPrintableCollection, IEquatable<Collection<T?>?> where T : class, IEquatable<T?>
    {

        #region Overridden collection methods

        /// <summary>
        ///     Adds an object to the end of the <see cref="T:System.Collections.ObjectModel.Collection`1"></see>.
        /// </summary>
        /// <param name="item">The object to be added to the end of the <see cref="T:System.Collections.ObjectModel.Collection`1"></see>. The value can be null for reference types.</param>
        public new void Add(T item)
        {
            if (Items.Contains(item)) return;
            base.Add(item);
        }

        #region AddRange

        /// <summary>
        ///     Adds the elements of the specified collection to the end of the <see cref="T:System.Collections.Generic.IEnumerable`1"></see>.
        /// </summary>
        /// <param name="collection">The collection whose elements should be added to the end of the <see cref="T:System.Collections.Generic.IEnumerable`1"></see>. The collection itself cannot be null, but it can contain elements that are null, if type T is a reference type.</param>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="collection">collection</paramref> is null.</exception>
        public void AddRange(IEnumerable<T> collection)
        {
            if (collection is null) throw new ArgumentNullException(nameof(collection));

            IList<T> list = collection.ToList();
            // ReSharper disable once ForCanBeConvertedToForeach
            for (int i = 0; i < list.Count; i++)
                if (!Items.Contains(list[i]))
                    base.Add(list[i]);
        }

        /// <summary>
        ///     Adds the elements of the specified collection to the end of the <see cref="T:System.Collections.Generic.IList`1"></see>.
        /// </summary>
        /// <param name="collection">The collection whose elements should be added to the end of the <see cref="T:System.Collections.Generic.IList`1"></see>. The collection itself cannot be null, but it can contain elements that are null, if type T is a reference type.</param>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="collection">collection</paramref> is null.</exception>
        public void AddRange(IList<T>? collection)
        {
            if (collection is null) throw new ArgumentNullException(nameof(collection));

            // ReSharper disable once ForCanBeConvertedToForeach
            for (int i = 0; i < collection.Count; i++)
                if (!Items.Contains(collection[i]))
                    base.Add(collection[i]);
        }
        /// <summary>
        ///     Adds the elements of the specified collection to the end of the <see cref="T:System.Collections.Generic.ICollection`1"></see>.
        /// </summary>
        /// <param name="collection">The collection whose elements should be added to the end of the <see cref="T:System.Collections.Generic.ICollection`1"></see>. The collection itself cannot be null, but it can contain elements that are null, if type T is a reference type.</param>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="collection">collection</paramref> is null.</exception>
        public void AddRange(ICollection<T> collection)
        {
            if (collection is null) throw new ArgumentNullException(nameof(collection));
            IList<T> list = collection.ToList();
            // ReSharper disable once ForCanBeConvertedToForeach
            for (int i = 0; i < list.Count; i++)
                if (!Items.Contains(list[i]))
                    base.Add(list[i]);
        }
        /// <summary>
        ///     Adds the elements of the specified collection to the end of the <see cref="T:System.Collections.Generic.IReadOnlyList`1"></see>.
        /// </summary>
        /// <param name="collection">The collection whose elements should be added to the end of the <see cref="T:System.Collections.Generic.IReadOnlyList`1"></see>. The collection itself cannot be null, but it can contain elements that are null, if type T is a reference type.</param>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="collection">collection</paramref> is null.</exception>
        public void AddRange(IReadOnlyList<T> collection)
        {
            if (collection is null) throw new ArgumentNullException(nameof(collection));
            // ReSharper disable once ForCanBeConvertedToForeach
            for (int i = 0; i < collection.Count; i++)
                if (!Items.Contains(collection[i]))
                    base.Add(collection[i]);
        }
        /// <summary>
        ///     Adds the elements of the specified collection to the end of the <see cref="T:System.Collections.Generic.IReadOnlyCollection`1"></see>.
        /// </summary>
        /// <param name="collection">The collection whose elements should be added to the end of the <see cref="T:System.Collections.Generic.IReadOnlyCollection`1"></see>. The collection itself cannot be null, but it can contain elements that are null, if type T is a reference type.</param>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="collection">collection</paramref> is null.</exception>
        public void AddRange(IReadOnlyCollection<T> collection)
        {
            IList<T> list = collection.ToList();
            // ReSharper disable once ForCanBeConvertedToForeach
            for (int i = 0; i < list.Count; i++)
                if (!Items.Contains(list[i]))
                    base.Add(list[i]);
        }

        #endregion

        #endregion

        #region Equatable

        /// <inheritdoc />
        public bool Equals(Collection<T?>? other)
        {
            if (other is null || other.Count != Count) return false;

            Func<int, bool> anotherTypeCondition = index => this[index] != other[index];
            Func<int, bool> stringCondition = index => !string.Equals(this[index] as string, other[index] as string, StringComparison.Ordinal);
            bool Condition(int index) => typeof(T) == typeof(string) ? stringCondition(index) : anotherTypeCondition(index);

            for (int i = 0; i < other.Count; i++)
                if (Condition(i))
                    return false;

            return true;
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked
            {
                if (Count == 0) return default;
                int hashCode = this[0]?.GetHashCode() ?? 0;

                for (int i = 0; i < Count; i++)
                    hashCode = (hashCode * 397) ^ (this[i]?.GetHashCode() ?? 0);

                return hashCode;
            }
        }

        /// <inheritdoc />
        public override bool Equals(object? obj) => ReferenceEquals(this, obj) || obj is Collection<T?> self && Equals(self);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator ==(WhatsAppApiCollection<T>? left, WhatsAppApiCollection<T>? right)
        {
            return right?.Equals(left) ?? left is null;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator !=(WhatsAppApiCollection<T>? left, WhatsAppApiCollection<T>? right)
        {
            return !(right?.Equals(left) ?? left is null);
        }

        #endregion

        #region Printable

        private const string Shift = "  ";
        private readonly StringBuilder _stringBuilder = new();

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

        /// <inheritdoc />
        public string PrintMembers()
        {
            int shift = default;
            _stringBuilder.AppendLine("[");

            if (Count == 0)
            {
                _stringBuilder.Append(GetShift(--shift) + "]");
                return _stringBuilder.ToString();
            }
            int maxPrint = Count >= 3 ? 3 : Count;
            string currentShift = GetShift(++shift);
            if (this[0] is Printable)
                for (int i = 0; i <= maxPrint - 1; i++)
                    _stringBuilder.AppendLine(string.Concat((this[i] as Printable)!.PrintMembers(shift), ", "));

            else if (this[0] is string || !typeof(T).IsInterface)
                for (int i = 0; i <= maxPrint - 1; i++)
                    _stringBuilder.AppendLine(string.Concat(currentShift, this[i], ", "));

            _stringBuilder.Remove(_stringBuilder.Length - shift - 1, shift + 1);
            if (Count > maxPrint) _stringBuilder.Append("\n" + currentShift + "... ");
            _stringBuilder.AppendLine();
            _stringBuilder.Append(GetShift(shift - 1) + "]");

            return _stringBuilder.ToString();
        }
        /// <inheritdoc />
        public string PrintMembers(int shift)
        {
            _stringBuilder.AppendLine("[");

            if (Count == 0)
            {
                _stringBuilder.Append(GetShift(--shift) + "]");
                return _stringBuilder.ToString();
            }
            int maxPrint = Count >= 3 ? 3 : Count;

            string currentShift = GetShift(++shift);
            if (this[0] is IPrintable)
                for (int i = 0; i <= maxPrint - 1; i++)
                    _stringBuilder.AppendLine(string.Concat((this[i] as Printable)!.PrintMembers(shift - 1), ", "));

            else if (!typeof(T).IsInterface || !typeof(T).IsClass)
                for (int i = 0; i <= maxPrint - 1; i++)
                    _stringBuilder.AppendLine(string.Concat(currentShift, this[i], ", "));

            _stringBuilder.Remove(_stringBuilder.Length - shift - 1, shift + 1);

            if (Count > maxPrint) _stringBuilder.Append("\n" + currentShift + "... ");
            _stringBuilder.AppendLine();
            _stringBuilder.Append(GetShift(shift - 1) + "]");

            return _stringBuilder.ToString();
        }

        /// <inheritdoc />
        public string PrintMembers(int countElementPrint, int shift)
        {
            _stringBuilder.AppendLine("[");

            if (Count == 0) return _stringBuilder.Append(GetShift(--shift) + "]").ToString();

            countElementPrint = countElementPrint > Count ? Count : countElementPrint;

            string currentShift = GetShift(++shift);
            if (this[0] is Printable)
                for (int i = 0; i <= countElementPrint - 1; i++)
                    _stringBuilder.AppendLine(string.Concat((this[i] as Printable)!.PrintMembers(shift), ", "));

            else if (this[0] is string || !typeof(T).IsInterface || !typeof(T).IsClass)
                for (int i = 0; i <= countElementPrint - 1; i++)
                    _stringBuilder.AppendLine(string.Concat(currentShift, this[i], ", "));

            _stringBuilder.Remove(_stringBuilder.Length - shift - 1, shift + 1);

            if (Count > countElementPrint) _stringBuilder.Append("\n" + currentShift + "... ");
            _stringBuilder.AppendLine();
            _stringBuilder.Append(GetShift(shift - 1) + "]");


            return _stringBuilder.ToString();
        }

        #endregion

    }
}
