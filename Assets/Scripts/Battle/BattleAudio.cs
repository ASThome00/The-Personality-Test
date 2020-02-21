using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleAudio : MonoBehaviour
{
    public AudioClip battleClip;
    public AudioSource battleMusic;
    static bool AudioBegin = false;
    void Start()
    {
        battleMusic.clip = battleClip;
    }
    // Start is called before the first frame update
    [System.Obsolete]
    void Update()
    {
        if (Application.loadedLevelName == "VictoryScreen" || Application.loadedLevelName == "DefeatEnding")
        {
            battleMusic.Stop();
            AudioBegin = false;
        }
    }

    void Awake()
    {
        if (!AudioBegin)
        {
            battleMusic.Play();
            DontDestroyOnLoad(gameObject);
            AudioBegin = true;
        }
    }
}
