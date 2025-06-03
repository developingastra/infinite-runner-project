using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    
    public float[] laneYPositions = new float[3] { -2.09f, - 3.14f, -4.09f };
    private int currentLane = 1; 

    public float laneSwitchSpeed = 10f; 

    void Update()
    {
        HandleInput();

       
        Vector3 targetPosition = new Vector3(transform.position.x, laneYPositions[currentLane], transform.position.z);
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * laneSwitchSpeed);
    }

    void HandleInput()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            if (currentLane > 0)
                currentLane--;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            if (currentLane < laneYPositions.Length - 1)
                currentLane++;
        }
    }
    void Start()
    {
        
    }

   
}
