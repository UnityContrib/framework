using UnityEngine;
using random = UnityEngine.Random;

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
                random.value - 0.5f,
                0.0f,
                random.value - 0.5f
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

        /// <summary>
        /// Returns random element from the specified <paramref name="array"/>.
        /// </summary>
        /// <typeparam name="T">
        /// The type of the elements in the array.
        /// </typeparam>
        /// <param name="array">
        /// The array containing the elements.
        /// </param>
        /// <returns>
        /// The random element; or default value of <typeparamref name="T"/> if array is null or empty.
        /// </returns>
        public static T Random<T>(T[] array)
        {
            if(array.IsNullOrEmpty())
            {
                return default(T);
            }

            var element = array[random.Range(0, array.Length)];
            return element;
        }
    }
}
