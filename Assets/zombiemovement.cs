using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombiemovement : MonoBehaviour
{
    public float moveSpeed = 3f;  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);

        if (transform.position.x < -10f) 
        {
            Destroy(gameObject);
        }
    }
}
