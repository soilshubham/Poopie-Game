using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BUTTONS : MonoBehaviour
{
    public GameObject main;
    public GameObject backB;
    public GameObject level;


    private void Start()
    {
        main.SetActive(true);
        level.SetActive(false);
        //backB.SetActive(false);
    }
    public void menu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void levelSelection()
    {
        main.SetActive(false);
        level.SetActive(true);
        //backB.SetActive(true);

    }

    public void backButton()
    {
        main.SetActive(true);
        level.SetActive(false);
        //backB.SetActive(false);

    }

    public void level01()
    {
        SceneManager.LoadScene("level01");

    }

}
