using System;
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace UnityContrib.UnityEditor
{
    /// <summary>
    /// Provides a set of helper methods for working with GUI in the editor.
    /// </summary>
    public static class EditorGUIUtilityEx
    {
        /// <summary>
        /// The <see cref="T:SystemType"/> of <see cref="T:UnityEditor.EditorGUIUtility"/> class.
        /// </summary>
        private static readonly Type editorGuiUtilityType = typeof(EditorGUIUtility);

        /// <summary>
        /// The <see cref="T:System.Reflection.MethodInfo"/> of the <see cref="T:UnityEditor.EditorGUIUtility.TextContent"/> method.
        /// </summary>
        private static readonly MethodInfo textContentMethod = editorGuiUtilityType.GetMethod("TextContent", BindingFlags.Static | BindingFlags.NonPublic);

        /// <summary>
        /// Returns the GUIContent from the Unity builtin resources with the specified <paramref name="name"/>.
        /// </summary>
        /// <param name="name">
        /// The name of the builtin resource.
        /// </param>
        /// <returns>
        /// The builtin text resource.
        /// </returns>
        public static GUIContent TextContent(string name)
        {
            return EditorGUIUtilityEx.textContentMethod.Invoke(null, new object[] { name }) as GUIContent;
        }
    }
}
