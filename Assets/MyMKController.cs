using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MK.Glow.Legacy;

public class MyMKController : MonoBehaviour
{
    float counter = 3;
    MKGlowFree mKGlow;
    float low = 2.5f, up = 5;
    private void Awake()
    {
        mKGlow = GetComponent<MKGlowFree>();
        StartCoroutine(Fade());
    }
    IEnumerator Fade()
    {
        while (true)
        {
            print("Hii");
            counter = low;
            do
            {
                counter += Time.deltaTime * 3.5f;
                mKGlow.bloomIntensity = counter;
                yield return null;
            } while (counter < up);
            counter = up;
            do
            {
                counter -= Time.deltaTime * 3.5f;
                mKGlow.bloomIntensity = counter;
                yield return null;
            } while (counter > low);
        }
    }
}
