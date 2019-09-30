using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ6 : MonoBehaviour
{
    [SerializeField] float w = 1;
    float t = 0;

    Light mLight;
    void Start()
    {
        mLight = GetComponent<Light>();   
    }

    void Update()
    {
        float y = -0.5f * (w * t) + 0.5f;
        t += Time.deltaTime;
        mLight.intensity = y;      
    }
}
