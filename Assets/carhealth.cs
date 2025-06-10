using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carhealth : MonoBehaviour
{
    [Header("Car Health Settings")]
    public int maxHealth = 10;  
    private int currentHealth;

   void Start()
    {
        currentHealth = maxHealth;  
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log("Car Health: " + currentHealth);

        if (currentHealth <= 0)
        {
            DestroyCar();
        }
    }

    
    private void DestroyCar()
    {
        Debug.Log("Car Destroyed!");
        Destroy(gameObject);  
    }

    void Update()
    {
        
    }
}
