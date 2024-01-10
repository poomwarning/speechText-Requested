using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



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
    
    
    
    public void QuitGame()
    {
        Application.Quit();
    }

}
