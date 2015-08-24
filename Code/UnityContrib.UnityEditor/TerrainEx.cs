using System;
using System.Reflection;
using UnityEngine;

namespace UnityContrib.UnityEditor
{
    /// <summary>
    /// Provides helper methods for working with the <see cref="T:UnityEngine.Terrain"/> class.
    /// </summary>
    public static class TerrainEx
    {
        /// <summary>
        /// The <see cref="T:SystemType"/> of <see cref="T:UnityEngine.Terrain"/> class.
        /// </summary>
        private static readonly Type terrainType = typeof(Terrain);

        /// <summary>
        /// The <see cref="T:System.Reflection.FieldInfo"/> of the <see cref="T:UnityEngine.Terrain.drawTreesAndFoliage"/> field.
        /// </summary>
        private static readonly FieldInfo drawTreesAndFoliageField = terrainType.GetField("drawTreesAndFoliage", BindingFlags.Instance | BindingFlags.NonPublic);

        /// <summary>
        /// Returns a value indicating if tree and foliage is drawn on the specified <paramref name="terrain"/>.
        /// </summary>
        /// <param name="terrain">
        /// The <see cref="T:UnityEngine.Terrain"/> to query.
        /// </param>
        /// <returns>
        /// true if trees and foliage is drawn; otherwise false.
        /// </returns>
        public static bool DrawTreesAndFoliage(this Terrain terrain)
        {
            return (bool)TerrainEx.drawTreesAndFoliageField.GetValue(terrain);
        }

        /// <summary>
        /// Assigns a value indicating if tree and foliage is drawn on the specified <paramref name="terrain"/>.
        /// </summary>
        /// <param name="terrain">
        /// The <see cref="T:UnityEngine.Terrain"/> to change.
        /// </param>
        /// <param name="value">
        /// true if trees and foliage is drawn; otherwise false.
        /// </param>
        public static void DrawTreesAndFoliage(this Terrain terrain, bool value)
        {
            TerrainEx.drawTreesAndFoliageField.SetValue(terrain, value);
        }
    }
}
