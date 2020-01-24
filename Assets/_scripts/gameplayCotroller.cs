using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameplayCotroller : MonoBehaviour
{
    public static bool canPlayAudio = true;
    public static bool death = false;
    public AudioSource deathSound;
    public float lowPassValue;

    public AudioLowPassFilter alpf;
    public AudioSource bg;
    void Start()
    {
        alpf.cutoffFrequency = 22000f;
        death = false;
    }

    void Update()
    {
        StartCoroutine(cutOff());    
    }
    IEnumerator cutOff()
    {
        yield return new WaitForSeconds(0.2f);
        if (death)
        {
            if (alpf.cutoffFrequency > 2000)
            {
                
                alpf.cutoffFrequency -= 1000;
            }
            if(bg.volume > 0.2)
            {
                bg.volume -= 0.01f;
            }
        }
    }
}
