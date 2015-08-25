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
    }
}
