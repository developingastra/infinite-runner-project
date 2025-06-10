using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerscore : MonoBehaviour
{
    public static playerscore Instance;
    private float timeElapsed = 0f;  
    private float score = 0f;      
    private bool isTimerRunning = true; 

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

    private void Update()
    {
        if (isTimerRunning)
        {
           
            timeElapsed += Time.deltaTime;

           
            score = timeElapsed;
            
            score = timeElapsed * 4;  

            uimanager.Instance.UpdateScore(Mathf.FloorToInt(score)); 
        }
    }

    
    public void StopTimer()
    {
        isTimerRunning = false;
    }

    
    public void ResetTimer()
    {
        timeElapsed = 0f;
        score = 0f;
        isTimerRunning = true;
    }
}
