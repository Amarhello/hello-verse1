using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour 
{
    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");

        
        
    }
    public void ExitGame()
    {
        Application.Quit(); 
    }
    public void Victory()
    {
        SceneManager.LoadScene("Victory");

    }
    public void StartMenu()
    {
        SceneManager.LoadScene("Victory");
    }
    
}




