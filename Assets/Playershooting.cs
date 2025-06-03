using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playershooting : MonoBehaviour
{
    public GameObject bulletsPrefab;
    public Transform Gunshot;   
    public int maxAmmo = 6;
    private int currentAmmo;

    public float reloadTime = 2f;
    private bool isReloading = false;
   
    void Start()
    {
        currentAmmo = maxAmmo;
    }

    
    void Update()
    {
        if (isReloading)
            return;
     
        if (Input.GetKeyDown(KeyCode.R) && currentAmmo < maxAmmo)
        {
            StartCoroutine(Reload());
            return;
        }

        if (currentAmmo <= 0)
        {
            StartCoroutine(Reload());
            return;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
        if (currentAmmo <= 0)
        {
            StartCoroutine(Reload());
            return;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        Instantiate(bulletsPrefab, Gunshot.position, Gunshot.rotation);
        currentAmmo--;
        Debug.Log("Shots left: " + currentAmmo);
    }

    System.Collections.IEnumerator Reload()
    {
        isReloading = true;
        Debug.Log("Reloading...");
        yield return new WaitForSeconds(reloadTime);
        currentAmmo = maxAmmo;
        isReloading = false;
        Debug.Log("Reloaded");
    }
}
