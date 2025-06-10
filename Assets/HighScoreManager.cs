using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreManager : MonoBehaviour
{
    public static HighScoreManager Instance; 

    [Header("UI Elements")]
    public Text highScoreText;  // Text UI to display the high score

    private int highScore;  // Variable to store the high score

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

        LoadHighScore();  // Load high score when the game starts
    }

    private void LoadHighScore()
    {
        highScore = PlayerPrefs.GetInt("HighScore", 0);  // Load saved high score, default to 0 if not set
        UpdateHighScoreText();
    }

    public void SaveHighScore(int score)
    {
        if (score > highScore)
        {
            highScore = score;  // Update high score if new score is higher
            PlayerPrefs.SetInt("HighScore", highScore);  // Save new high score
            PlayerPrefs.Save();  // Save changes
            UpdateHighScoreText();  // Update the UI
        }
    }

    private void UpdateHighScoreText()
    {
        highScoreText.text = "High Score: " + highScore.ToString();  // Update the UI with the high score
    }
}
