using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityContrib.UnityEngine
{
    /// <summary>
    /// Records an entry for the timeline.
    /// </summary>
    /// <example>
    /// using(new TimelineLog("Example", "Waiting", "Waiting for 2.5 seconds"))
    /// {
    ///     yield return new WaitForSeconds(2.5f);
    /// }
    /// </example>
    public class TimelineLog : IDisposable
    {
        /// <summary>
        /// Hashtable of sources.
        /// The key is the name of the source.
        /// The value is another hashtable containing the categories of the source.
        /// </summary>
        /// <remarks>
        /// <see cref="T:System.Collections.Hashtable"/> is much faster than <see cref="T:System.Collections.Generic.Dictionary`2"/>.
        /// </remarks>
        private static readonly Hashtable sources = new Hashtable();

        /// <summary>
        /// The source of the entry.
        /// </summary>
        private string source;

        /// <summary>
        /// The category of the entry.
        /// </summary>
        private string category;

        /// <summary>
        /// The message of the entry.
        /// </summary>
        private string message;

        /// <summary>
        /// The time in seconds when the log entry started.
        /// </summary>
        private float start;

        /// <summary>
        /// Gets or sets the color of the log entry when displayed.
        /// </summary>
        public Color Color
        {
            get;
            set;
        }

        /// <summary>
        /// Gets the sources logged.
        /// </summary>
        public static IDictionary Sources
        {
            get
            {
                return TimelineLog.sources;
            }
        }

        /// <summary>
        /// Gets the maximum time in seconds logged.
        /// </summary>
        public static float MaxTime
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the number of sources logged.
        /// </summary>
        public static int TotalSources
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the number of categories logged across sources.
        /// </summary>
        public static int TotalCategories
        {
            get;
            private set;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:UnityContrib.UnityEngine.TimelineLog"/> class.
        /// </summary>
        /// <param name="source">
        /// The source of the entry.
        /// </param>
        /// <param name="category">
        /// The category of the entry.
        /// </param>
        /// <param name="message">
        /// The message of the entry.
        /// </param>
        public TimelineLog(string source, string category, string message)
        {
            this.source = source;
            this.category = category;
            this.message = message;
            this.start = Time.time;
            this.Color = Color.white;
        }

        /// <summary>
        /// Finalizes the log entry and records it.
        /// </summary>
        public void Dispose()
        {
            var end = Time.time;

            var source = TimelineLog.sources[this.source] as TimelineLogSource;
            if (source == null)
            {
                TimelineLog.sources[this.source]
                    = source
                    = new TimelineLogSource()
                    ;
                TimelineLog.TotalSources++;
            }

            var entries = source.Categories[this.category] as LinkedList<TimelineLogEntry>;
            if (entries == null)
            {
                source.Categories[this.category]
                    = entries
                    = new LinkedList<TimelineLogEntry>()
                    ;
                TimelineLog.TotalCategories++;
            }

            var entry = new TimelineLogEntry(this.message, this.start, end, this.Color);
            entries.AddLast(entry);

            TimelineLog.MaxTime = Mathf.Max(TimelineLog.MaxTime, entry.End);
        }

        /// <summary>
        /// Clears the timeline.
        /// </summary>
        public static void Clear()
        {
            TimelineLog.sources.Clear();
            TimelineLog.MaxTime = 0.0f;
            TimelineLog.TotalSources = 0;
            TimelineLog.TotalCategories = 0;
        }
    }
}
