using System;
using System.Collections.Generic;

namespace UnityContrib.UnityEngine
{
    /// <summary>
    /// Provies a set of helper methods for working with the
    /// <see cref="T:System.Collections.IEnumerable"/> and
    /// <see cref="T:System.Collections.Generic.IEnumerable`1"/> classes.
    /// </summary>
    public static class IEnumerableEx
    {
        /// <summary>
        /// Searches for the specified <paramref name="predicate"/>
        /// and returns the index of its first occurrence in the enumerable.
        /// </summary>
        /// <typeparam name="T">
        /// The type of the elements of source.
        /// </typeparam>
        /// <param name="source">
        /// The enumerable to search.
        /// </param>
        /// <param name="predicate">
        /// A function to test each element for a condition.
        /// </param>
        /// <returns>
        /// The index of the first occurrence of <paramref name="predicate"/>, if found; otherwise minus 1.
        /// </returns>
        public static int IndexOf<T>(this IEnumerable<T> source, Predicate<T> predicate)
        {
            var index = 0;
            foreach (var element in source)
            {
                if (predicate(element))
                {
                    return index;
                }
                index++;
            }
            return -1;
        }

        /// <summary>
        /// Performs the specified action on each element of the <see cref="T:System.Collections.Generic.IEnumerable`1"/>.
        /// </summary>
        /// <typeparam name="T">
        /// The type of the elements of <paramref name="source"/>.
        /// </typeparam>
        /// <param name="source">
        /// An <see cref="T:System.Collections.Generic.IEnumerable`1"/> to iterate trough.
        /// </param>
        /// <param name="action">
        /// The <see cref="T:System.Action`1"/> delegate to perform on each element of the <see cref="T:System.Collections.Generic.IEnumerable`1"/>.
        /// </param>
        /// <returns>
        /// The source for further processing.
        /// </returns>
        public static IEnumerable<T> ForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            foreach (var element in source)
            {
                action(element);
            }
            return source;
        }
    }
}
