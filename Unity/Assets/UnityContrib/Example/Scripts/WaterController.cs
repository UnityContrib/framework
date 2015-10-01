using UnityContrib.UnityEngine;
using UnityEngine;

/// <summary>
/// Makes the water follow a target.
/// 
/// Useful when you don't want to have an extremely huge water surface to fill the whole map.
/// </summary>
public class WaterController : MonoBehaviour
{
#pragma warning disable 0649 // Field 'XYZ' is never assigned to, and will always have it's default value null

    /// <summary>
    /// The selector to use to find the target.
    /// </summary>
    [SerializeField]
    [Tooltip("The selector to use to find the target.")]
    private BaseSelector targetSelector;

#pragma warning restore 0649 // Field 'XYZ' is never assigned to, and will always have it's default value null

    /// <summary>
    /// Disables the component if dependencies are not available.
    /// </summary>
    private void Awake()
    {
        this.targetSelector.DisableIfNull(this.targetSelector, "targetSelector");
    }

    /// <summary>
    /// Positions the water at the target's position, keeping Y at zero.
    /// </summary>
    private void Update()
    {
        var target = this.targetSelector.Selected;
        if (target == null)
        {
            Debug.LogWarning("No target selected.");
            return;
        }

        var position = target.position;
        position.y = 0.0f;
        this.transform.position = position;
    }
}
