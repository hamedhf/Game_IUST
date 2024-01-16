using UnityEngine;

public class CarLightController : MonoBehaviour
{
    public Shader lightOnShader;
    public Shader lightOffShader;

    private MeshRenderer carMeshRenderer;
    private bool lightsOn = false;

    void Start()
    {
        carMeshRenderer = GetComponent<MeshRenderer>();
        // Initially, turn off the lights
        TurnOffLights();
    }

    void Update()
    {
        // Example: Toggle lights on key press (you can use any condition to toggle lights)
        if (Input.GetKeyDown(KeyCode.L))
        {
            ToggleLights();
        }
    }

    void TurnOnLights()
    {
        carMeshRenderer.material.shader = lightOnShader;
        lightsOn = true;
    }

    void TurnOffLights()
    {
        carMeshRenderer.material.shader = lightOffShader;
        lightsOn = false;
    }

    void ToggleLights()
    {
        if (lightsOn)
        {
            TurnOffLights();
        }
        else
        {
            TurnOnLights();
        }
    }
}
