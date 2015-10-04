using System.Collections;

namespace UnityContrib.UnityEngine
{
    /// <summary>
    /// Source information for log entries in the timeline.
    /// </summary>
    public class TimelineLogSource
    {
        /// <summary>
        /// Gets the categories of the source.
        /// </summary>
        public Hashtable Categories
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets or sets a value indicating if the source is folded as opposed to expanded.
        /// </summary>
        public bool IsFolded
        {
            get;
            set;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:UnityContrib.UnityEngine"/> class.
        /// </summary>
        public TimelineLogSource()
        {
            this.Categories = new Hashtable();
        }
    }
}
