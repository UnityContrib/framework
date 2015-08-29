using UnityEngine;

namespace UnityContrib.UnityEngine
{
    /// <summary>
    /// Provides a set of helper methods for debugging.
    /// </summary>
    public class DebugEx
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
    }
}
