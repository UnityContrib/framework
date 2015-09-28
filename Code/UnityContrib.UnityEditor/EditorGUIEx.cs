using System;
using UnityEditor;
using UnityEngine;

namespace UnityContrib.UnityEditor
{
    /// <summary>
    /// Provides helper methods for working with the <see cref="T:UnityEngine.GUI"/> and <see cref="T:UnityEditor.EditorGUI"/> classes.
    /// </summary>
    public static partial class EditorGUIEx
    {
        /// <summary>
        /// Draws a rectangle at the spcified <paramref name="rect"/> with the specified <paramref name="color"/>.
        /// </summary>
        /// <param name="rect">
        /// The position and size of the rectangle.
        /// </param>
        /// <param name="color">
        /// The color of the rectangle.
        /// </param>
        public static void DrawRectangle(Rect rect, Color color)
        {
            GUI.color = color;
            GUI.DrawTexture(rect, global::UnityEditor.EditorGUIUtility.whiteTexture);
            GUI.color = Color.white;
        }

        /// <summary>
        /// Check if any control was changed inside a block of code.
        /// </summary>
        /// <param name="content">
        /// The callback to invoke between start and end change check.
        /// </param>
        /// <returns>
        /// true if changed; otherwise false.
        /// </returns>
        public static bool ChangeCheck(Action content)
        {
            var hasChange = false;
            EditorGUI.BeginChangeCheck();
            try
            {
                content();
            }
            finally
            {
                hasChange = EditorGUI.EndChangeCheck();
            }
            return hasChange;
        }
    }
}
