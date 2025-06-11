using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carhealth : MonoBehaviour
{
    public static carhealth Instance; 
    
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;  
        }
        else
        {
            Destroy(gameObject);  
        }
    }

   
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("Zombie"))
        {
          
            Debug.Log("Car hit by a zombie! Game Over!");

          
            GameOverManager.Instance.ShowGameOver(HighScoreManager.Instance.GetHighScore());

           
            Destroy(gameObject);
        }
    }
}
