using UnityContrib.UnityEngine;
using UnityEngine;

public class WaterController : MonoBehaviour
{
    [SerializeField]
    private BaseSelector targetSelector;

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

        var position = target.position;
        position.y = 0.0f;
        this.transform.position = position;
    }
}
