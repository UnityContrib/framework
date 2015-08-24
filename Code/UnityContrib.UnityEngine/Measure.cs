using System;
using UnityEngine;

namespace UnityContrib.UnityEngine
{
    /// <summary>
    /// Provides methods for doing measurements of code execution.
    /// </summary>
    public static class Measure
    {
        /// <summary>
        /// Measures the time the specified <paramref name="action"/> takes to execute.
        /// </summary>
        /// <param name="action">
        /// The action to measure.
        /// </param>
        public static float Time(Action action)
        {
            var start = global::UnityEngine.Time.realtimeSinceStartup;
            action();
            var end = global::UnityEngine.Time.realtimeSinceStartup;
            var delta = end - start;
            return delta;
        }

        /// <summary>
        /// Measures the time the specified <paramref name="action"/> takes to execute.
        /// </summary>
        /// <param name="caption">
        /// The caption of the measurement.
        /// </param>
        /// <param name="action">
        /// The action to measure.
        /// </param>
        public static void DebugLogTime(string caption, Action action)
        {
            var time = Measure.Time(action);
            Debug.Log("Time Measure: " + caption + " (" + time + "ms)");
        }
    }
}