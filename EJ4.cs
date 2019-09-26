using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ4 : MonoBehaviour
{
    Light mLuz;
    Transform mT;
    void Start()
    {
        mLuz = GetComponent<Light>();
        mT = GetComponent<Transform>();
    }

    
    void Update()
    {
        mLuz.intensity = 0.5f * mT.localScale.magnitude;
    }
}
