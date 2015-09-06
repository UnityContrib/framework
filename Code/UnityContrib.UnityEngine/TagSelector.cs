using UnityEngine;

namespace UnityContrib.UnityEngine
{
    /// <summary>
    /// Selects the game object having a specific tag name.
    /// </summary>
    public class TagSelector : BaseSelector
    {
        /// <summary>
        /// The tag name of the game object to select.
        /// </summary>
        [SerializeField]
        [Tooltip("The tag name of the game object to select.")]
        private string tagName;

        /// <summary>
        /// Gets or sets the tag name of the game object to select.
        /// </summary>
        public string TagName
        {
            get
            {
                return this.tagName;
            }
            set
            {
                if(this.tagName == value)
                {
                    return;
                }

                this.tagName = value;
                this.Reselect();
            }
        }

        /// <summary>
        /// Returns the selected <see cref="T:UnityEngine.Transform"/> based on the <see cref="P:UnityContrib.UnityEngine.TagSelector.TagName"/>.
        /// </summary>
        /// <returns>
        /// The selected <see cref="T:UnityEngine.Transform"/>.
        /// </returns>
        protected override Transform Select()
        {
            var gameObject = GameObject.FindGameObjectWithTag(this.tagName);
            if(gameObject == null)
            {
                Debug.LogWarning("No game object found with the tag name \"" + this.tagName + "\".");
                return null;
            }

            var transform = gameObject.transform;
            return transform;
        }
    }
}
