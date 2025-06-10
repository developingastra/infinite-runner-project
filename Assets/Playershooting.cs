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

    [SerializeField] private audiomanager audiomanager;

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
            audiomanager.PlayReloadSound();
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
            audiomanager.PlayGunshotSound();
        }
        if (currentAmmo <= 0)
        {
            StartCoroutine(Reload());
            audiomanager.PlayReloadSound();
            return;
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
