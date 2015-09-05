using UnityEngine;

namespace UnityContrib.UnityEngine
{
    /// <summary>
    /// Base implementation for selectors.
    /// 
    /// A selector is a component that selects a <see cref="T:UnityEngine.Transform"/>.
    /// The advantage of using this component is that you don't need to write the same find game object code over and over.
    /// You can simply attach an instance of a selector to a game object and let that instance find the <see cref="T:UnityEngine.Transform"/> for you.
    /// </summary>
    public abstract class BaseSelector : MonoBehaviour
    {
        /// <summary>
        /// The cached reference to the selected <see cref="T:UnityEngine.Transform"/>.
        /// </summary>
        private Transform selected;

        /// <summary>
        /// Gets the selected <see cref="T:UnityEngine.Transform"/>.
        /// </summary>
        public Transform Selected
        {
            get
            {
                if (this.selected != null)
                {
                    return this.selected;
                }

                this.selected = this.Select();
                return this.selected;
            }
        }

        /// <summary>
        /// Returns the selected <see cref="T:UnityEngine.Transform"/>.
        /// </summary>
        /// <param name="selector">
        /// The selector that selects the <see cref="T:UnityEngine.Transform"/>.
        /// </param>
        public static implicit operator Transform(BaseSelector selector)
        {
            return selector.Selected;
        }

        /// <summary>
        /// When implemented, returns the selected <see cref="T:UnityEngine.Transform"/>.
        /// </summary>
        /// <returns></returns>
        protected abstract Transform Select();
    }
}
