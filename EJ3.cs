using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ3 : MonoBehaviour
{
    Light mLuz;
  
    void Start()
    {
        mLuz = GetComponent<Light>();
    }


    void Update()
    {
        Color r = new Color(0.88f, 0.094f, 0.094f);
        Color a = new Color(0.078f, 0.10f, 0.83f);
        Color b = new Color(0.9f, 0.9f, 0.9f);

        if (mLuz.intensity>=0.25 && mLuz.intensity <= 0.5)
        {
            mLuz.color = a;
        }
        if (mLuz.intensity >= 0.5 && mLuz.intensity <= 0.75)
        {
            mLuz.color = r;
        }
        if (mLuz.intensity >= 0.75)
        {
            mLuz.color = b;
        }
    }
}
