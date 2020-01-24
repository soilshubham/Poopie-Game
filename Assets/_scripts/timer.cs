using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{

    public Text scoreDisplay;
    public int highscore = 0;
    public Text percnt1;
    public Text percnt2;
    public int currentPercnt;
    int ongoingpercent;
    void Start()
    {
        currentPercnt = 0;
        highscore = PlayerPrefs.GetInt("lvl01HS");

    }

    void Update()
    {
        if(currentPercnt > PlayerPrefs.GetInt("lvl01HS", 0))
        {
            PlayerPrefs.SetInt("lvl01HS", currentPercnt);
        }
        if (controlls.canmove)
        {
            currentPercnt = (int)((Time.timeSinceLevelLoad / 64) * 100);
        }
        else
        {
        }
        scoreDisplay.text = "B E S T - " + PlayerPrefs.GetInt("lvl01HS") + "%";
        percnt1.text = currentPercnt + "%";
        percnt2.text = currentPercnt + "%";

    }
}
