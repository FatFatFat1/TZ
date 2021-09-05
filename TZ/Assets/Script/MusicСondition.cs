using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicСondition : MonoBehaviour
{
    public GameObject soundSource;
    bool music;
    private void Awake()
    {
        music = MyVariable.musicСondition;
    }

    private void Start()
    {
        if(!music)
        {
            soundSource.SetActive(false);
        }

    }
}
