using System;
using UnityEngine;

namespace UnityContrib.UnityEngine
{
    /// <summary>
    /// Provides helper methods for working with the <see cref="T:UnityEngine.GUI"/> class.
    /// </summary>
    public static partial class GUIEx
    {
        /// <summary>
        /// Begin a scrolling view inside your GUI.
        /// 
        /// ScrollViews let you make a smaller area on-screen look 'into' a much larger area, using scrollbars placed on the sides of the ScrollView.
        /// </summary>
        /// <param name="rect">
        /// Rectangle on the screen to use for the ScrollView.
        /// </param>
        /// <param name="scrollPosition">
        /// The pixel distance that the view is scrolled in the X and Y directions.
        /// </param>
        /// <param name="viewRect">
        /// The rectangle used inside the scrollview.
        /// </param>
        /// <param name="horizontalScrollbar">
        /// GUIStyle to use for the horizontal scrollbar. If left out, the horizontalScrollbar style from the current GUISkin is used.
        /// </param>
        /// <param name="verticalScrollbar">
        /// GUIStyle to use for the vertical scrollbar. If left out, the verticalScrollbar style from the current GUISkin is used.
        /// </param>
        /// <param name="action">
        /// The callback that renders the controls.
        /// </param>
        /// <returns>
        /// The modified scrollPosition. Feed this back into the variable you pass in.
        /// </returns>
        public static Vector2 ScrollView(Rect rect, Vector2 scrollPosition, Rect viewRect, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, Action action)
        {
            scrollPosition = GUI.BeginScrollView(rect, scrollPosition, viewRect, horizontalScrollbar, verticalScrollbar);
            try
            {
                action();
            }
            finally
            {
                GUI.EndScrollView();
            }
            return scrollPosition;
        }
    }
}
