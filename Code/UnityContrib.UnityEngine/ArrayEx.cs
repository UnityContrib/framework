using System;

namespace UnityContrib.UnityEngine
{
    /// <summary>
    /// Provides a set of helper methods for working with the <see cref="T:System.Array"/> class.
    /// </summary>
    public static class ArrayEx
    {
        /// <summary>
        /// Returns a value indicating if the specified <paramref name="array"/> is null or is empty.
        /// </summary>
        /// <param name="array">
        /// The array to evaluate.
        /// </param>
        /// <returns>
        /// true if the array is null or empty; otherwise false.
        /// </returns>
        public static bool IsNullOrEmpty(this Array array)
        {
            var result
                = array == null
                || array.Length == 0
                ;
            return result;
        }

        /// <summary>
        /// Swaps the elements at indicies <paramref name="i1"/> and <paramref name="i2"/>.
        /// </summary>
        /// <typeparam name="T">
        /// The type of the elements in the array.
        /// </typeparam>
        /// <param name="source">
        /// The array containg the elements to swap.
        /// </param>
        /// <param name="i1">
        /// The index of one of the elements to swap.
        /// </param>
        /// <param name="i2">
        /// The index of the other element to swap.
        /// </param>
        public static void Swap<T>(this T[] source, int i1, int i2)
        {
            var t = source[i1];
            source[i1] = source[i2];
            source[i2] = t;
        }
    }
}
