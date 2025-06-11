using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreManager : MonoBehaviour
{
    public static HighScoreManager Instance; 

    [Header("UI Elements")]
    public Text highScoreText;  
    private int highScore;

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

        LoadHighScore();  
    }


    private void LoadHighScore()
    {
        highScore = PlayerPrefs.GetInt("HighScore", 0);  
        UpdateHighScoreText();
    }

   
    public void SaveHighScore(int score)
    {
        if (score > highScore)
        {
            highScore = score;  
            PlayerPrefs.SetInt("HighScore", highScore);
            PlayerPrefs.Save();  
            UpdateHighScoreText(); 
        }
    }

    
    private void UpdateHighScoreText()
    {
        highScoreText.text = "High Score: " + highScore.ToString();  
    }

   
    public int GetHighScore()
    {
        return highScore;
    }

}
