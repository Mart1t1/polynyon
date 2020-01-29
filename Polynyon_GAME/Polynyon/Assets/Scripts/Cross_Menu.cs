using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cross_Menu : MonoBehaviour
{

    public void OptionMenu()
    {
        SceneManager.UnloadSceneAsync("MENUOK");
        SceneManager.LoadScene("Options", LoadSceneMode.Additive); 
    }
    public void BackToMenu()
    {
        SceneManager.UnloadSceneAsync("Options");
        SceneManager.LoadScene("MENUOK", LoadSceneMode.Additive);
    }

    public void ExitGame()
    {
        Application.Quit(); 
    }
}
