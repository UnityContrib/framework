using UnityEngine;

namespace UnityContrib.UnityEngine
{
    /// <summary>
    /// Provides a set of helper methods for working with the <see cref="T:UnityEngine.Vector3"/> struct.
    /// </summary>
    public static class Vector3Ex
    {
        /// <summary>
        /// Returns a random position around the specified center <paramref name="position"/>.
        /// 
        /// The Y component of the random position will always be the same as the center position.
        /// </summary>
        /// <param name="position">
        /// The center position to generate a random position around.
        /// </param>
        /// <param name="distance">
        /// The distance from the center position to the generated random position.
        /// </param>
        /// <returns>
        /// The generated random position.
        /// </returns>
        /// <example>
        /// public void Example()
        /// {
        ///     var center = Vector3(100.0f, 100.0f, 100.0f);
        ///     var around = center.Around(20.0f);
        /// }
        /// </example>
        public static Vector3 Around(this Vector3 position, float distance)
        {
            var vector = RandomEx.Vector3XZ() * distance + position;
            return vector;
        }
    }
}
