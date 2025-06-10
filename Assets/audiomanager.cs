using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audiomanager : MonoBehaviour
{
    [SerializeField] AudioSource musicsource;
    [SerializeField] AudioSource SFXsource;

    public AudioClip backgorund;
    public AudioClip reload;
    public AudioClip gunshot;

    void Start()
    {
        musicsource.clip = backgorund;
        musicsource.Play();
    }

    public void PlaySFX (AudioClip clip)
    {
        SFXsource.PlayOneShot(clip);
    }
    public void PlayReloadSound()
    {
        PlaySFX(reload);  // Play the reload sound
    }

    public void PlayGunshotSound()
    {
        PlaySFX(gunshot);  // Play the gunshot sound
    }
    void Update()
    {
        
    }
}
