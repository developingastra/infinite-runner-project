using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parralaxroad : MonoBehaviour
{
    public float scrollSpeed = 1f;
    public float tileWidth = 20f;

    private Vector3 startPosition;

    void Start()
    {
        var sr = GetComponent<SpriteRenderer>();
        Debug.Log("Width in units: " + sr.bounds.size.x);
        startPosition = transform.position;
    }

    void Update()
    {
        float newPos = Mathf.Repeat(Time.time * scrollSpeed, tileWidth);
        transform.position = startPosition + Vector3.left * newPos;
    }
}
