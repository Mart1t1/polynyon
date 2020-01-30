using System;
using System.Collections;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class Cross_Menu : MonoBehaviour
{
    public GameObject image; 

    

    public void OptionMenu()
    {
        if (SceneManager.GetSceneByName("DontDestroyOnLoad").isLoaded) Debug.Log("wow"); 
        SceneManager.UnloadSceneAsync("MENUOK");
        SceneManager.LoadScene("Options", LoadSceneMode.Additive);
    }

    public void BackToMenu()
    {
        SceneManager.UnloadSceneAsync("Options");
        SceneManager.LoadScene("MENUOK", LoadSceneMode.Additive);
        DontDestroyOnLoad(image); 
    }

    public void ExitGame()
    {
        Application.Quit(); 
    }
}
