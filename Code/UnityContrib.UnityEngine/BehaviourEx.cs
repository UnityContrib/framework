using UnityEngine;

namespace UnityContrib.UnityEngine
{
    /// <summary>
    /// Provides a set of helper methods for working with the <see cref="T:UnityEngine.Behaviour"/> class.
    /// </summary>
    public static class BehaviourEx
    {
        /// <summary>
        /// Disables the behaviour if the specified <paramref name="value"/> is null.
        /// </summary>
        /// <param name="value">
        /// The value to null test.
        /// </param>
        /// <param name="behaviour">
        /// The behaviour to disable.
        /// </param>
        /// <param name="variableName">
        /// The name of the value variable used in the warning message.
        /// </param>
        public static T DisableIfNull<T>(this T value, Behaviour behaviour, string variableName) where T : class
        {
            if (value == null)
            {
                behaviour.enabled = false;
                Debug.LogWarning("Disabled behaviour \"" + behaviour.name + "\" because \"" + variableName + "\" was null.");
            }
            return value;
        }
    }
}
