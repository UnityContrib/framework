using UnityEngine;

namespace UnityContrib.UnityEngine
{
    /// <summary>
    /// Component that tells the engine not to unload the game object when scene changes.
    /// </summary>
    public class DontDestroyOnLoad : MonoBehaviour
    {
        /// <summary>
        /// Informs the engine not to unload the game object.
        /// </summary>
        private void Awake()
        {
            GameObject.DontDestroyOnLoad(this.gameObject);
        }
    }
}
