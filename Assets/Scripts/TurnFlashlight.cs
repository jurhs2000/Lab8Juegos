using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnFlashlight : MonoBehaviour
{
    public Light light;
    public AudioSource audio;
    private float intensity = 0;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            audio.Play();
            if (intensity == 0)
                intensity = 5.05f;
            else
                intensity = 0;
            light.intensity = intensity;
        }
    }
}
