using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleloader : MonoBehaviour
{

    public GameObject part1;
    public GameObject part2;
    public GameObject part3;
    
    void Start()
    {
        part1.SetActive(true);
        part2.SetActive(false);
        part3.SetActive(false);
    }
    void Update()
    {
        if (controlls.canmove)
        {
            if (Time.timeSinceLevelLoad > 20)
            {
                part2.SetActive(true);

            }

            if (Time.timeSinceLevelLoad > 30)
            {
                part1.SetActive(false);
            }



            if (Time.timeSinceLevelLoad > 40)
            {
                part2.SetActive(false);
                part3.SetActive(true);
            }
            if (Time.timeSinceLevelLoad > 50)
            {
                part2.SetActive(false);
            }
        }
    }
}
