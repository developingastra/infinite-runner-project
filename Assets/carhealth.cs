using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carhealth : MonoBehaviour
{
    public static carhealth Instance;  

    [Header("Car Health Settings")]
    public int maxHealth = 10;
    private int currentHealth;

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

    void Start()
    {
        currentHealth = maxHealth;
        
        if (uimanager.Instance != null)
        {
            uimanager.Instance.UpdateHealth(currentHealth);  
        }
        else
        {
            Debug.LogError("UIManager is not initialized or present in the scene.");
        }
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        Debug.Log("Car hit! Game Over!");

       
        GameOverManager.Instance.ShowGameOver(HighScoreManager.Instance.GetCurrentScore());

        
        Destroy(gameObject);
    }
    private void Die()
    {
        Debug.Log("Car Destroyed!");
       
        Destroy(gameObject);
    }

    void Update()
    {
        
    }
}
