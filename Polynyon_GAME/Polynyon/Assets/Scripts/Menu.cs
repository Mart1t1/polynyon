using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject Menuu;
    private bool Checkk = false;

    public void PlayGame()
    {
        
        SceneManager.LoadScene(1);
        
    }

  

    public void QuitGame()
    {
        Application.Quit();
    }
}
