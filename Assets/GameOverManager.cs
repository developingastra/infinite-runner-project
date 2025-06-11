using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverManager : MonoBehaviour
{
    public static GameOverManager Instance;  

    [Header("UI Elements")]
    public GameObject gameOverPanel; 
    public Text finalScoreText;       
    public Text highScoreText;       
    public Button restartButton;      
    public Button quitButton;         

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

        gameOverPanel.SetActive(false);  
    }

    
    public void ShowGameOver(int score)
    {
        gameOverPanel.SetActive(true); 

        
        finalScoreText.text = "Final Score: " + score.ToString();

        
        HighScoreManager.Instance.SaveHighScore(score);  
        highScoreText.text = "High Score: " + HighScoreManager.Instance.GetHighScore().ToString();  

       
        restartButton.interactable = true;
        quitButton.interactable = true;
    }

    
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); 
    }

   
    public void QuitGame()
    {
        Application.Quit();
    }
}
