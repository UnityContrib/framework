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
    }
}
