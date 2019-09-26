using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ2 : MonoBehaviour
{
    Renderer mRender; 
    float t=0;
    void Start()
    {
        mRender = GetComponent<Renderer>();
    }

    void Update()
    {
        Color r = new Color(0.88f, 0.094f, 0.094f);
        Color a = new Color(0.078f, 0.10f, 0.83f);
        Color m = new Color(0.41f, 0.015f, 0.51f);

        t += Time.deltaTime;
        if (t >= 0 && t <= 3)
        {
            mRender.material.color = r;
        }
        if (t >= 3 && t <= 6 )
        {
            mRender.material.color = a;
        }
        if (t >= 6)
        {
            mRender.material.color = m;
        }
    }
}
