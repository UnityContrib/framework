using UnityContrib.UnityEngine;
using UnityEngine;

/// <summary>
/// Positions and rotates the camera to follow and look at the target.
/// </summary>
public class CameraController : MonoBehaviour
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
    /// The distance away, to the side and above the target.
    /// </summary>
    [SerializeField]
    [Tooltip("The distance away, to the side and above the target.")]
    private Vector3 offset = new Vector3(0.0f, 3.0f, 5.0f);

    /// <summary>
    /// The speed of which the camera follows the target.
    /// </summary>
    [SerializeField]
    private float speed = 1.0f;

    /// <summary>
    /// Disables the component if dependencies are not available.
    /// </summary>
    private void Awake()
    {
        this.targetSelector.DisableIfNull(this.targetSelector, "targetSelector");
    }

    /// <summary>
    /// Positions and rotates the camera to follow and look at the target.
    /// </summary>
    private void Update()
    {
        var target = this.targetSelector.Selected;
        if (target == null)
        {
            Debug.LogWarning("No target selected.");
            return;
        }

        // calculate target position
        var targetPosition = target.position;
        targetPosition.x += this.offset.x;
        targetPosition.y += this.offset.y;
        targetPosition -= target.forward * this.offset.z;

        // calculate target forward (look at)
        var targetForward = target.position - this.transform.position;

        // interpolate from current to target position
        this.transform.position = Vector3.Lerp(this.transform.position, targetPosition, Time.deltaTime * this.speed);

        // interpolate from current to target forward
        this.transform.forward = Vector3.Lerp(this.transform.forward, targetForward, Time.deltaTime * this.speed);
    }
}
