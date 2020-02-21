using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryAudio : MonoBehaviour
{
    public AudioClip victoryClip;
    public AudioSource victoryMusic;
    static bool AudioBegin = false;
    void Start()
    {
        victoryMusic.clip = victoryClip;
    }
    // Start is called before the first frame update
    [System.Obsolete]
    void Update()
    {
        
    }

    void Awake()
    {
        if (!AudioBegin)
        {
            victoryMusic.Play();
            DontDestroyOnLoad(gameObject);
            AudioBegin = true;
        }
    }
}
