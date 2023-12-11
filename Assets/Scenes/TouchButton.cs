using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TouchButton : MonoBehaviour
{
    public void Home()
    {
        SceneManager.LoadScene(1);
    }

    public void PlaySceen()
    {
        SceneManager.LoadScene(2);
    }
    
    // public void Guidebook()
    // {
    //     SceneManager.LoadScene(3);
    // }
    
    // public void Credit()
    // {
    //     SceneManager.LoadScene(4);
    // }
    
    public void QuitGame()
    {
        Application.Quit();
    }

}
