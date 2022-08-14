using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{
    public Light lightflash;
    public bool lightOff;
    public float lighIntensity; 

    // Update is called once per frame

    public void Awake()
    {
        lightOff = false;
        lightflash = GetComponent<Light>();
        lightflash.intensity = lighIntensity;
    }


    void Update()
    {
        lightflash.intensity = lighIntensity;
        
        while (lightflash.intensity > 0)
        {
            lightflash.intensity--;          
        }
        lightOff = true;

    }
}
