using System.Collections;
using UnityEngine;

public class CanvasBillboard : MonoBehaviour
{
    private IEnumerator Start()
    {
        var camera = Camera.main.transform;

        while (Application.isPlaying)
        {
            this.transform.forward = this.transform.position - camera.position;
            yield return null;
        }
    }
}
