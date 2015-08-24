using System;
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace UnityContrib.UnityEditor
{
    /// <summary>
    /// Provides a set of helper methods for working with the <see cref="T:UnityEngine.Shader"/> class.
    /// </summary>
    public static class ShaderUtilEx
    {
        /// <summary>
        /// The <see cref="T:SystemType"/> of <see cref="T:UnityEditor.ShaderUtil"/> class.
        /// </summary>
        private static readonly Type shaderUtilType = typeof(ShaderUtil);

        /// <summary>
        /// The <see cref="T:System.Reflection.MethodInfo"/> of the <see cref="T:UnityEditor.ShaderUtil.HasTangentChannel"/> method.
        /// </summary>
        private static readonly MethodInfo hasTangentChannelMethod = shaderUtilType.GetMethod("HasTangentChannel", BindingFlags.Static | BindingFlags.NonPublic);

        /// <summary>
        /// Returns a value indicating if the specified <paramref name="shader"/> has a tangent channel.
        /// </summary>
        /// <param name="shader">
        /// The shader to query.
        /// </param>
        /// <returns>
        /// true if the shader has a tangent channel; otherwise false.
        /// </returns>
        public static bool HasTangentChannel(this Shader shader)
        {
            return (bool)ShaderUtilEx.hasTangentChannelMethod.Invoke(null, new object[] { shader });
        }
    }
}
