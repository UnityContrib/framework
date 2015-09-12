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
        /// The color of the path.
        /// </param>
        /// <param name="duration">
        /// The amount of seconds the path must be visible for.
        /// A duration of zero shows the path for just one frame.
        /// </param>
        /// <param name="depthTest">
        /// A value indicating whether or not the path be obscured by objects closer to the camera?
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

        /// <summary>
        /// Draws a sphere at the specified <paramref name="position"/>.
        /// </summary>
        /// <param name="position">
        /// The position to draw the sphere at.
        /// </param>
        /// <param name="radius">
        /// The radius of the sphere.
        /// </param>
        /// <param name="color">
        /// The color of the sphere.
        /// </param>
        /// <param name="duration">
        /// The amount of seconds the line must be visible for.
        /// A duration of zero shows the line for just one frame.
        /// </param>
        /// <param name="depthTest">
        /// A value indicating whether or not the line be obscured by objects closer to the camera?
        /// </param>
        public static void DrawSphere(Vector3 position, float radius, Color color, float duration, bool depthTest)
        {
            const float twoPi = Mathf.PI * 2.0f; // full 360 degrees in radians
            float segments = 8.0f; // "row" count
            float sides = 8.0f; // "column" count

            var halfRadius = radius * 0.5f;
            var previousRadius = 0.0f;
            var previousY = 0.0f;

            for (var segment = 0.0f; segment < segments; segment++)
            {
                var segmentTime = segment / (segments - 1);
                var segmentRadius = Mathf.Sin(segmentTime * Mathf.PI) * halfRadius;
                var y = position.y + Mathf.Cos(segmentTime * Mathf.PI) * halfRadius;

                for (var side = 0.0f; side < sides; side++)
                {
                    var angleStart = side / sides * twoPi;
                    var angleEnd = (side + 1.0f) / sides * twoPi;

                    var start = new Vector3(
                        position.x + Mathf.Cos(angleStart) * segmentRadius,
                        y,
                        position.z + Mathf.Sin(angleStart) * segmentRadius
                       );
                    var end = new Vector3(
                        position.x + Mathf.Cos(angleEnd) * segmentRadius,
                        y,
                        position.z + Mathf.Sin(angleEnd) * segmentRadius
                        );

                    // draw "horizontal" line
                    Debug.DrawLine(start, end, color, duration, depthTest);

                    if (segment != 0.0f)
                    {
                        end = new Vector3(
                            position.x + Mathf.Cos(angleStart) * previousRadius,
                            previousY,
                            position.z + Mathf.Sin(angleStart) * previousRadius
                           );

                        // draw "vertical" line
                        Debug.DrawLine(start, end, color, duration, depthTest);
                    }
                }

                previousRadius = segmentRadius;
                previousY = y;
            }
        }
    }
}
