using UnityEngine;
using Random = UnityEngine.Random;

namespace UnityContrib.UnityEngine
{
    /// <summary>
    /// Provides a set of helper methods for working with random values.
    /// </summary>
    public static class RandomEx
    {
        /// <summary>
        /// Returns a random point inside a circle with a radius of 1.
        /// The Y component is always 0.0.
        /// </summary>
        /// <returns>
        /// The random vector.
        /// </returns>
        public static Vector3 Vector3XZ()
        {
            var vector = new Vector3(
                Random.value * 2.0f - 1.0f,
                0.0f,
                Random.value * 2.0f - 1.0f
                );
            vector.Normalize();
            return vector;
        }

        /// <summary>
        /// Returns a random point inside a circle.
        /// The Y component is always 0.0.
        /// </summary>
        /// <param name="distance">
        /// This distance from the center of the circle to the point.
        /// </param>
        /// <returns>
        /// The random vector.
        /// </returns>
        public static Vector3 Vector3XZ(float distance)
        {
            var vector = RandomEx.Vector3XZ();
            vector *= distance;
            return vector;
        }
    }
}
