using UnityEngine;

namespace UnityContrib.UnityEngine
{
    /// <summary>
    /// Log entry for the timeline.
    /// </summary>
    public class TimelineLogEntry
    {
        /// <summary>
        /// Gets the message for the log entry.
        /// </summary>
        public string Message
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the time in seconds when the log entry started.
        /// </summary>
        public float Start
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the time in seconds when the log entry ended.
        /// </summary>
        public float End
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the color of the log entry when displayed.
        /// </summary>
        public Color Color
        {
            get;
            private set;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:UnityContrib.UnityEngine.TimelineLogEntry"/> class.
        /// </summary>
        /// <param name="message">
        /// The textual message for the log entry.
        /// </param>
        /// <param name="start">
        /// The time in seconds when the log entry started.
        /// </param>
        /// <param name="end">
        /// The time in seconds when the log entry started.
        /// </param>
        /// <param name="color">
        /// The color of the log entry when displayed.
        /// </param>
        public TimelineLogEntry(string message, float start, float end, Color color)
        {
            this.Message = message;
            this.Start = start;
            this.End = end;
            this.Color = color;
        }
    }
}
