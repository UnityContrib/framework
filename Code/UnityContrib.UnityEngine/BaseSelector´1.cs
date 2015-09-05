using UnityEngine;

namespace UnityContrib.UnityEngine
{
    /// <summary>
    /// Generic base implementation for selectors that selects <see cref="T:UnityEngine.Component"/>.
    /// 
    /// A selector is a component that selects a <see cref="T:UnityEngine.Transform"/>.
    /// The advantage of using this component is that you don't need to write the same find game object code over and over.
    /// You can simply attach an instance of a selector to a game object and let that instance find the <see cref="T:UnityEngine.Transform"/> for you.
    /// </summary>
    public abstract class BaseSelector<TComponent> : BaseSelector where TComponent : Component
    {
        /// <summary>
        /// Returns the <see cref="T:UnityEngine.Transform"/> containing the <typeparamref name="TComponent"/> component.
        /// </summary>
        /// <returns></returns>
        protected override Transform Select()
        {
            var component = GameObject.FindObjectOfType<TComponent>();
            return component.transform;
        }
    }
}
