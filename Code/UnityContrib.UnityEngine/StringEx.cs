using System;

namespace UnityContrib.UnityEngine
{
    /// <summary>
    /// Provides a set of helper methods for working with the <see cref="T:System.String"/> class.
    /// </summary>
    public static class StringEx
    {
        /// <summary>
        /// Returns a value indicating whether a specified substring occurs within this string.
        /// </summary>
        /// <param name="text">
        /// The string to search in.
        /// </param>
        /// <param name="value">
        /// The string to seek. 
        /// </param>
        /// <param name="comparisonType">
        /// One of the enumeration values that specifies the rules for the search.
        /// </param>
        /// <returns>
        /// true if the value parameter occurs within this string, or if value is the empty string (""); otherwise, false.
        /// </returns>
        public static bool Contains(this string text, string value, StringComparison comparisonType)
        {
            return text.IndexOf(value, comparisonType) > -1;
        }
    }
}
