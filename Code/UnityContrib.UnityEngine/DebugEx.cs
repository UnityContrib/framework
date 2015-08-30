using UnityEngine;

namespace UnityContrib.UnityEngine
{
    /// <summary>
    /// Provides a set of helper methods for debugging.
    /// </summary>
    public static class DebugEx
    {
        /// <summary>
        /// Draws 3 lines intersecting each other at the specified <paramref name="position"/>.
        /// </summary>
        /// <param name="position">
        /// The position where the 3 lines intersect.
        /// </param>
        /// <param name="size">
        /// The length of each line.
        /// </param>
        /// <param name="color">
        /// The color of the lines.
        /// </param>
        /// <param name="duration">
        /// The amount of seconds the line must be visible for.
        /// A duration of zero shows the line for just one frame.
        /// </param>
        /// <param name="depthTest">
        /// A value indicating whether or not the line be obscured by objects closer to the camera?
        /// </param>
        public static void DrawCross3D(Vector3 position, float size, Color color, float duration = 0.0f, bool depthTest = true)
        {
            var halfSize = size * 0.5f;
            Debug.DrawLine(position - Vector3.left * halfSize, position + Vector3.left * halfSize, color, duration, depthTest);
            Debug.DrawLine(position - Vector3.up * halfSize, position + Vector3.up * halfSize, color, duration, depthTest);
            Debug.DrawLine(position - Vector3.forward * halfSize, position + Vector3.forward * halfSize, color, duration, depthTest);
        }

        /// <summary>
        /// Draws the specified <paramref name="path"/>.
        /// </summary>
        /// <param name="path">
        /// The path to draw.
        /// </param>
        /// <param name="start">
        /// The start of the path.
        /// </param>
        /// <param name="end">
        /// The end of the path.
        /// </param>
        /// <param name="color">
        /// The color of the line.
        /// </param>
        /// <param name="duration">
        /// The amount of seconds the line must be visible for.
        /// A duration of zero shows the line for just one frame.
        /// </param>
        /// <param name="depthTest">
        /// A value indicating whether or not the line be obscured by objects closer to the camera?
        /// </param>
        public static void DrawPath(NavMeshPath path, Vector3 start, Vector3 end, Color color, float duration = 0.0f, bool depthTest = true)
        {
            if (path.corners.Length > 0)
            {
                Debug.DrawLine(start, path.corners[0], color, duration, depthTest);
                for (var index = 0; index < path.corners.Length - 1; index++)
                {
                    Debug.DrawLine(path.corners[index], path.corners[index + 1], color, duration, depthTest);
                }
                Debug.DrawLine(path.corners[path.corners.Length - 1], end, color, duration, depthTest);
            }
            else
            {
                Debug.DrawLine(start, end, color, duration, depthTest);
            }
        }
    }
}
