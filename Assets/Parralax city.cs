using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parralax : MonoBehaviour
{
    public float scrollSpeed = 4f;     
    public float tileWidth = 20f;       

    private Vector3 startPosition;

    void Start()
    {
        var sr = GetComponent<SpriteRenderer>();
        Debug.Log("Width in units: city" + sr.bounds.size.x);
        startPosition = transform.position;
    }

    void Update()
    {
        float newPos = Mathf.Repeat(Time.time * scrollSpeed, tileWidth);
        transform.position = startPosition + Vector3.left * newPos;
    }
    
}
