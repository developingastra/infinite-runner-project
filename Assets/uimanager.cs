using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uimanager : MonoBehaviour
{
    public static uimanager Instance;  

    [Header("UI Elements")]
    public Slider healthBar;   
    public Text ammoText;      
    public Text scoreText;    

    private int playerHealth = 3;
    private int maxHealth = 3;
    private int ammoCount = 6;

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

    private void Start()
    {
        healthBar.maxValue = maxHealth;
        healthBar.value = playerHealth;

        UpdateAmmoText();
        UpdateScoreText();  
    }

    public void UpdateHealth(int health)
    {
        playerHealth = Mathf.Clamp(health, 0, maxHealth);
        healthBar.value = playerHealth;
    }

    public void UpdateAmmo(int ammo)
    {
        ammoCount = Mathf.Max(0, ammo);
        UpdateAmmoText();
    }

    void UpdateAmmoText()
    {
        ammoText.text = "Ammo: " + ammoCount.ToString();
    }

    public void UpdateScore(int points)
    {
        scoreText.text = "Distance traveled: " + points.ToString() + " M"; 
    }

    
    public void UpdateScoreText()
    {
        scoreText.text = "Distance traveled: " + "0 M";  
    }
}
