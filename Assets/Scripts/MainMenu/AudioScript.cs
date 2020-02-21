using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioScript : MonoBehaviour
{

    public AudioClip menuMusic;
    public AudioSource menuSource;
    static bool AudioBegin = false;
    public static AudioClip click;
    public AudioClip test;
    static AudioSource audioSource;

    void Start()
    {
        menuSource.clip = menuMusic;
        audioSource = GetComponent<AudioSource>();
        click = test;
    }

    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {
        if (Application.loadedLevelName == "Battle")
        {
            menuSource.Stop();
            AudioBegin = false;
        }
    }
    
    void Awake()
    {
        if (!AudioBegin)
        {
            menuSource.Play();
            DontDestroyOnLoad(gameObject);
            AudioBegin = true;
        }
    }

    public static void playClick() {
        audioSource.PlayOneShot(click, 1);
    }   
}
