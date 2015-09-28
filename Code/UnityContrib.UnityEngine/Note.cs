using UnityEngine;

namespace UnityContrib.UnityEngine
{
    /// <summary>
    /// A note component for game objects.
    /// </summary>
    [AddComponentMenu("Designer/Note")]
    public class Note : MonoBehaviour
    {
#pragma warning disable 0169 // The field 'XYZ' is never used

        /// <summary>
        /// The note.
        /// </summary>
        /// <remarks>
        /// By design this field is never used in code.
        /// </remarks>
        [SerializeField]
        [Tooltip("The note.")]
        [MultilineWithWordWrap]
        private string text;

#pragma warning restore 0169 // The field 'XYZ' is never used
    }
}
