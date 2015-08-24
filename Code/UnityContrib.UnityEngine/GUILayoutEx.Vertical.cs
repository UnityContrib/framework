using System;
using UnityEngine;

namespace UnityContrib.UnityEngine
{
    /// <summary>
    /// Provides helper methods for working with the <see cref="T:UnityEngine.GUILayout"/> class.
    /// </summary>
    public static partial class GUILayoutEx
    {
        /// <summary>
        /// All controls rendered inside this method will be placed vertically below each other.
        /// </summary>
        /// <param name="action">
        /// The callback that renders the controls.
        /// </param>
        /// <param name="options">
        /// An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.
        /// </param>
        public static void Vertical(Action action, params GUILayoutOption[] options)
        {
            GUILayout.BeginVertical(options);
            try
            {
                action();
            }
            finally
            {
                GUILayout.EndVertical();
            }
        }

        /// <summary>
        /// All controls rendered inside this method will be placed vertically below each other.
        /// </summary>
        /// <param name="action">
        /// The callback that renders the controls.
        /// </param>
        /// <param name="style">
        /// The style to use for background image and padding values. If left out, the background is transparent.
        /// </param>
        /// <param name="options">
        /// An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.
        /// </param>
        public static void Vertical(Action action, GUIStyle style, params GUILayoutOption[] options)
        {
            GUILayout.BeginVertical(style, options);
            try
            {
                action();
            }
            finally
            {
                GUILayout.EndVertical();
            }
        }

        /// <summary>
        /// All controls rendered inside this method will be placed vertically below each other.
        /// </summary>
        /// <param name="action">
        /// The callback that renders the controls.
        /// </param>
        /// <param name="content">
        /// The text, image, and tooltip for this group.
        /// </param>
        /// <param name="style">
        /// The style to use for background image and padding values. If left out, the background is transparent.
        /// </param>
        /// <param name="options">
        /// An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.
        /// </param>
        public static void Vertical(Action action, GUIContent content, GUIStyle style, params GUILayoutOption[] options)
        {
            GUILayout.BeginVertical(content, style, options);
            try
            {
                action();
            }
            finally
            {
                GUILayout.EndVertical();
            }
        }

        /// <summary>
        /// All controls rendered inside this method will be placed vertically below each other.
        /// </summary>
        /// <param name="action">
        /// The callback that renders the controls.
        /// </param>
        /// <param name="text">
        /// The text to display on group.
        /// </param>
        /// <param name="style">
        /// The style to use for background image and padding values. If left out, the background is transparent.
        /// </param>
        /// <param name="options">
        /// An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.
        /// </param>
        public static void Vertical(Action action, string text, GUIStyle style, params GUILayoutOption[] options)
        {
            GUILayout.BeginVertical(text, style, options);
            try
            {
                action();
            }
            finally
            {
                GUILayout.EndVertical();
            }
        }

        /// <summary>
        /// All controls rendered inside this method will be placed vertically below each other.
        /// </summary>
        /// <param name="action">
        /// The callback that renders the controls.
        /// </param>
        /// <param name="image">
        /// The texture to display on group.
        /// </param>
        /// <param name="style">
        /// The style to use for background image and padding values. If left out, the background is transparent.
        /// </param>
        /// <param name="options">
        /// An optional list of layout options that specify extra layouting properties. Any values passed in here will override settings defined by the style.
        /// </param>
        public static void Vertical(Action action, Texture2D image, GUIStyle style, params GUILayoutOption[] options)
        {
            GUILayout.BeginVertical(image, style, options);
            try
            {
                action();
            }
            finally
            {
                GUILayout.EndVertical();
            }
        }
    }
}
