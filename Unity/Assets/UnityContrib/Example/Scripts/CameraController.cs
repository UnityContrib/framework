using UnityContrib.UnityEngine;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private BaseSelector targetSelector;

    [SerializeField]
    private Vector3 offset = new Vector3(0.0f, 3.0f, 5.0f);

    [SerializeField]
    private float speed = 1.0f;

    private void Awake()
    {
        this.targetSelector.DisableIfNull(this.targetSelector, "targetSelector");
    }

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
