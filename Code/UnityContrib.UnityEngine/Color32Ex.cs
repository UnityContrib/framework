using UnityEngine;

namespace UnityContrib.UnityEngine
{
    /// <summary>
    /// Provides a set of helper methods for working with the <see cref="T:UnityEngine.Color32"/> struct.
    /// </summary>
    public static class Color32Ex
    {
        /// <summary>
        /// Returns a value indicating whether or not the specified <see cref="T:UnityEngine.Color32"/> are equal.
        /// </summary>
        /// <param name="value">
        /// The left side <see cref="T:UnityEngine.Color32"/> of the comparison.
        /// </param>
        /// <param name="other">
        /// The right side <see cref="T:UnityEngine.Color32"/> of the comparison.
        /// </param>
        /// <returns>
        /// true if equal; otherwise false.
        /// </returns>
        public static bool Equals(this Color32 value, Color32 other)
        {
            return
                value.a.Equals(other.a)
                && value.r.Equals(other.r)
                && value.b.Equals(other.b)
                && value.g.Equals(other.g)
                ;
        }
    }
}
