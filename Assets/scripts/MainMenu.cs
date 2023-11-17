using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenu : MonoBehaviour
{
    public int difficultLevel;
    
    void Start()
    {
        PlayerPrefs.DeleteAll();
    }

    public void DropDown(int index)
    {
        switch (index)
        {
            case 0: difficultLevel = 1; Debug.Log(difficultLevel); break;
            case 1: difficultLevel = 2; Debug.Log(difficultLevel); break;
            case 2: difficultLevel = 3; Debug.Log(difficultLevel); break;

        }
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(difficultLevel); //loads index 1 in build
    }

    


    public void QuitGame()
    {
        Application.Quit();
    }
}
