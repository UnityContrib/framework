using UnityEngine;

namespace UnityContrib.UnityEngine
{
    /// <summary>
    /// Provides a set of helper methods for working with the <see cref="T:UnityEngine.NavMeshPath"/> class.
    /// </summary>
    public static class NavMeshPathEx
    {
        /// <summary>
        /// Calculates the distance between the specified <paramref name="start"/> and <paramref name="end"/> using the specified <paramref name="path"/>.
        /// </summary>
        /// <param name="path">
        /// The path who's distance to calculate.
        /// </param>
        /// <param name="start">
        /// The start of the path.
        /// </param>
        /// <param name="end">
        /// The end of the path.
        /// </param>
        /// <returns>
        /// The distance from start to end measured in Unity units.
        /// </returns>
        public static float Distance(this NavMeshPath path, Vector3 start, Vector3 end)
        {
            var distance = 0.0f;
            if (path.corners.Length > 0)
            {
                distance += Vector3.Distance(start, path.corners[0]);
                for (var index = 0; index < path.corners.Length - 1; index++)
                {
                    distance += Vector3.Distance(path.corners[index], path.corners[index + 1]);
                }
                distance += Vector3.Distance(path.corners[path.corners.Length - 1], end);
            }
            else
            {
                distance = Vector3.Distance(start, end);
            }
            return distance;
        }
    }
}
