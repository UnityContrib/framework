using System.Collections.Generic;
using UnityEngine;

namespace UnityContrib.UnityEngine
{
    /// <summary>
    /// Provides helper methods for working with the <see cref="T:UnityEngine.Transform"/> class.
    /// </summary>
    public static class TransformEx
    {
        /// <summary>
        /// Destroys all the children of the specified <paramref name="parent"/> <see cref="T:UnityEngine.Transform"/>.
        /// </summary>
        /// <param name="parent">
        /// The parent <see cref="T:UnityEngine.Transform"/> who's children to destroy.
        /// </param>
        public static void DestroyAllChildren(this Transform parent)
        {
            // starting at the back of the list to ensure it still works the day Unity destroys the children immediatly
            for (var index = parent.childCount - 1; index >= 0; index--)
            {
                var child = parent.GetChild(index);
                GameObject.Destroy(child.gameObject);
            }
        }

        /// <summary>
        /// Destroys all the children of the specified <paramref name="parent"/> <see cref="T:UnityEngine.Transform"/>.
        /// </summary>
        /// <param name="parent">
        /// The parent <see cref="T:UnityEngine.Transform"/> who's children to destroy.
        /// </param>
        public static void DestroyImmediateAllChildren(this Transform parent)
        {
            // starting at the back of the list to ensure it still works the day Unity destroys the children immediatly
            for (var index = parent.childCount - 1; index >= 0; index--)
            {
                var child = parent.GetChild(index);
                GameObject.DestroyImmediate(child.gameObject);
            }
        }

        /// <summary>
        /// Returns all the decendant <see cref="T:UnityEngine.Transform"/> to the specified <paramref name="transform"/> using depth first traversal.
        /// </summary>
        /// <param name="transform">
        /// The parent <see cref="T:UnityEngine.Transform"/> to start at.
        /// </param>
        /// <returns>
        /// An enumerable of <see cref="T:UnityEngine.Transform"/>.
        /// </returns>
        public static IEnumerable<Transform> DecendantsDepthFirst(this Transform transform)
        {
            for (var childIndex = 0; childIndex < transform.childCount; childIndex++)
            {
                var childTransform = transform.GetChild(childIndex);
                var decendants = childTransform.DecendantsDepthFirst();
                foreach (var decendant in decendants)
                {
                    yield return decendant;
                }
                yield return childTransform;
            }
        }

        /// <summary>
        /// Returns all the decendant <see cref="T:UnityEngine.Transform"/> to the specified <paramref name="transform"/> using breadth first traversal.
        /// </summary>
        /// <param name="transform">
        /// The parent <see cref="T:UnityEngine.Transform"/> to start at.
        /// </param>
        /// <returns>
        /// An enumerable of <see cref="T:UnityEngine.Transform"/>.
        /// </returns>
        public static IEnumerable<Transform> DecendantsBreadthFirst(this Transform transform)
        {
            for (var childIndex = 0; childIndex < transform.childCount; childIndex++)
            {
                var childTransform = transform.GetChild(childIndex);
                yield return childTransform;
                var decendants = childTransform.DecendantsBreadthFirst();
                foreach (var decendant in decendants)
                {
                    yield return decendant;
                }
            }
        }
    }
}
