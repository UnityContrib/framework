using System.Linq;
using UnityEngine;

public class TrafficLight : MonoBehaviour
{
    private Color greenBright = new Color(0.0f, 1.0f, 0.0f);
    private Color greenDim = new Color(0.0f, 64.0f / 255.0f, 0.0f); 
    private Color yellowBright = new Color(1.0f, 191.0f / 255.0f, 0.0f);
    private Color yellowDim = new Color(64.0f / 255.0f, 48.0f / 255.0f, 0.0f); 
    private Color redBright = new Color(1.0f, 0.0f, 0.0f);
    private Color redDim = new Color(64.0f / 255.0f, 0.0f, 0.0f); 

    private Material green;
    private Material yellow;
    private Material red;

    public bool IsGreen
    {
        get
        {
            return this.green.color == this.greenBright;
        }
    }

    public bool IsYellow
    {
        get
        {
            return this.yellow.color == this.yellowBright;
        }
    }

    public bool IsRed
    {
        get
        {
            return this.red.color == this.redBright;
        }
    }

    private void Awake()
    {
        var renderer = this.GetComponent<MeshRenderer>();

        var sharedMaterials = renderer.sharedMaterials;
        var green = sharedMaterials.FirstOrDefault(m => m.name == "TrafficLight-Green_6");
        var yellow = sharedMaterials.FirstOrDefault(m => m.name == "TrafficLight-Yellow_6");
        var red = sharedMaterials.FirstOrDefault(m => m.name == "TrafficLight-Red_6");

        var materials = new Material[sharedMaterials.Length];
        materials[0] = sharedMaterials[0];
        materials[1] = sharedMaterials[1];
        materials[2] = this.red = new Material(red);
        materials[3] = this.yellow = new Material(yellow);
        materials[4] = this.green = new Material(green);
        renderer.materials = materials;
    }

    public void Set(bool green, bool yellow, bool red)
    {
        this.green.color
            = green
            ? this.greenBright
            : this.greenDim
            ;
        this.yellow.color
            = yellow
            ? this.yellowBright
            : this.yellowDim
            ;
        this.red.color
            = red
            ? this.redBright
            : this.redDim
            ;
    }
}
