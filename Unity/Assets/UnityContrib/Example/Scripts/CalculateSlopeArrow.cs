using System;
using System.Collections;
using UnityContrib.UnityEngine;
using UnityEngine;
using UnityEngine.UI;

public class CalculateSlopeArrow : MonoBehaviour
{
    [SerializeField]
    private float vSpeed = 1.0f;

    [SerializeField]
    private float hSpeed = 1.0f;

#pragma warning disable 0649 // Field 'XYZ' is never assigned to, and will always have it's default value null

    [SerializeField]
    private Text text;

    [SerializeField]
    private Transform arrow;

#pragma warning restore 0649 // Field 'XYZ' is never assigned to, and will always have it's default value null

    /// <summary>
    /// Rotates the arrow and updates the text with the slope of the arrow.
    /// </summary>
    /// <returns>
    /// An enumerable to iterate through.
    /// 
    /// Will keep iterating as long as the program is playing.
    /// </returns>
    private IEnumerator Start()
    {
        var textParent = this.text.transform.parent;
        var camera = Camera.main.transform;

        while (Application.isPlaying)
        {
            var forward = new Vector3(
                Mathf.Sin(Time.time * this.hSpeed),
                Mathf.Sin(Time.time * this.vSpeed) * 3.0f,
                Mathf.Cos(Time.time * this.hSpeed)
                );
            forward.Normalize();
            this.arrow.forward = forward;
            Debug.DrawLine(this.arrow.position, this.arrow.position + forward * 2.0f, Color.magenta);

            // update text and point it towards the camera
            this.text.text
                = "Visualization of the method" + Environment.NewLine
                + "float CalculateSlopeRad(Vector3 normal)" + Environment.NewLine
                + forward.CalculateSlopeDeg().ToString("#,##0.00°")
                ;
            textParent.forward = textParent.position - camera.position;

            yield return null;
        }
    }
}
