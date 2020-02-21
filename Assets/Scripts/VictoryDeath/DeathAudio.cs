using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathAudio : MonoBehaviour
{
    public AudioClip deathClip;
    public AudioSource deathMusic;
    static bool AudioBegin = false;
    void Start()
    {
        deathMusic.clip = deathClip;
        deathMusic.Play();
    }
}
