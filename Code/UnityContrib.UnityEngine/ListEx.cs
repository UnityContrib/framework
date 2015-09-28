using System.Collections.Generic;

namespace UnityContrib.UnityEngine
{
    /// <summary>
    /// Provides a set of helper methods for working with the <see cref="T:System.Collections.Generic.List`1"/> class.
    /// </summary>
    public static class ListEx
    {
        /// <summary>
        /// Swaps the elements at indicies <paramref name="i1"/> and <paramref name="i2"/>.
        /// </summary>
        /// <typeparam name="T">
        /// The type of the elements in the list.
        /// </typeparam>
        /// <param name="source">
        /// The list containg the elements to swap.
        /// </param>
        /// <param name="i1">
        /// The index of one of the elements to swap.
        /// </param>
        /// <param name="i2">
        /// The index of the other element to swap.
        /// </param>
        public static void Swap<T>(this List<T> source, int i1, int i2)
        {
            var t = source[i1];
            source[i1] = source[i2];
            source[i2] = t;
        }
    }
}
