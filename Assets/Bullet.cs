using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;
    public float lifetime = 2f;
    public float damage = 25f;

    void Start()
    {
        Destroy(gameObject, lifetime);
    }

    
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Zombie"))
        {
            zombie zombie = other.GetComponent<zombie>();
            if (zombie != null)
            {
                zombie.TakeDamage(damage);
            }

            Destroy(gameObject);
        }
    }
}
