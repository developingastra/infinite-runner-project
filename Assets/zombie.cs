using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class ZombieSkin
{
    public string name;
    public RuntimeAnimatorController animatorOverride;
    public Sprite previewIcon; 
}
public class zombie : MonoBehaviour
{
    private Animator animator;

    [Header("Zombie Skins")]
    public ZombieSkin[] zombieSkins;

    public int maxHealth = 2;
    private int currentHealth;
    private bool isDead = false;

    void Start()
    {
        animator = GetComponent<Animator>();
        RandomizeSkin();
        currentHealth = maxHealth;

        animator.SetBool("isWalking", true);
    }

    void RandomizeSkin()
    {
        if (zombieSkins.Length == 0) return;

        int index = Random.Range(0, zombieSkins.Length);
        animator.runtimeAnimatorController = zombieSkins[index].animatorOverride;
    }

    public void TakeDamage(float damage)
    {
        if (isDead) return;

        currentHealth -= Mathf.RoundToInt(damage);

        if (currentHealth <= 0)
        {
            Die();
        }
        else
        {
            animator.SetTrigger("Hurt");
        }
    }

    private void Die()
    {
        if (isDead) return;
        isDead = true;
        animator.SetTrigger("Dead");
        Destroy(gameObject, 1f);
    }
        private void OnTriggerEnter2D(Collider2D other)
        {
          
            if (other.CompareTag("Car"))
            {
                
                Debug.Log("Zombie hit the car! Game Over!");

                
                GameOverManager.Instance.ShowGameOver(HighScoreManager.Instance.GetHighScore());

                Destroy(gameObject);
            }
        }
    

}
