using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombie : MonoBehaviour
{
    private Animator animator;
    private SpriteRenderer spriteRenderer;
    public Sprite[] zombieSkins;  
    public int maxHealth = 2;   
    private int currentHealth;

    void Start()
    {
        animator = GetComponent<Animator>();  
        spriteRenderer = GetComponent<SpriteRenderer>();  

        RandomizeZombieSkin();  
        currentHealth = maxHealth;  
    }

    // Update is called once per frame
    void Update()
    {
        
        if (currentHealth <= 0)
        {
            animator.SetTrigger("Dead"); 
            Destroy(gameObject);          
        }
        
        else if (currentHealth < maxHealth)
        {
            animator.SetTrigger("Hurt");  
        }
       
        else
        {
            animator.SetBool("isWalking", true);  
        }
    }
    void RandomizeZombieSkin()
    {
        int randomIndex = Random.Range(0, zombieSkins.Length);  
        spriteRenderer.sprite = zombieSkins[randomIndex];        
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            animator.SetTrigger("Dead");  
        }
        else
        {
            animator.SetTrigger("Hurt");  
        }
    }
}
