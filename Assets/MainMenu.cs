using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMneu : MonoBehaviour
{
    public void PlayGame()
    {
        Debug.Log("PlayGame called");
        SceneManager.LoadScene("game");
    }

    public void ExitGame()
    {
        Debug.Log("ExitGame called");
        Application.Quit();
    }
   
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
