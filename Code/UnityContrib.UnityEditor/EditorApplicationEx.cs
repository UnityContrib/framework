using System;
using System.Reflection;
using UnityEditor;

namespace UnityContrib.UnityEditor
{
    /// <summary>
    /// Provides a set of helper methods for working with the <see cref="T:UnityEditor.EditorApplication"/> class.
    /// </summary>
    public static class EditorApplicationEx
    {
        /// <summary>
        /// The <see cref="T:SystemType"/> of <see cref="T:UnityEditor.EditorApplication"/> class.
        /// </summary>
        private static readonly Type editorApplicationType = typeof(EditorApplication);

        /// <summary>
        /// The <see cref="T:System.Reflection.MethodInfo"/> of the <see cref="T:UnityEditor.EditorApplication.SetSceneRepaintDirty"/> method.
        /// </summary>
        private static readonly MethodInfo setSceneRepaintDirtyMethod = editorApplicationType.GetMethod("SetSceneRepaintDirty", BindingFlags.Static | BindingFlags.NonPublic);

        /// <summary>
        /// Flags repainting of the scene.
        /// </summary>
        public static void SetSceneRepaintDirty()
        {
            EditorApplicationEx.setSceneRepaintDirtyMethod.Invoke(null, new object[0]);
        }
    }
}
