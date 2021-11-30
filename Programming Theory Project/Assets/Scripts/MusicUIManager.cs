using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MusicUIManager : MonoBehaviour
{
    // Start is called before the first frame update
    private Toggle musicButton;

    public AudioSource musicSource;




    private void Awake()
    {
        /*   DontDestroyOnLoad(musicButton); */

    }
    void Start()
    {
        musicButton = FindObjectOfType<Toggle>();


        MusicManager.music = PlayerPrefs.GetInt("Music");

        if (MusicManager.music == 1)
        {
            musicButton.GetComponent<Toggle>().isOn = true;
        }
        else if (MusicManager.music == 0)
        {
            musicButton.GetComponent<Toggle>().isOn = false;
        }
    }

    

    public void ToggleMusic()
    {
        bool isOn = musicButton.GetComponent<Toggle>().isOn;
        musicSource.mute = isOn;
        if (isOn)
            MusicManager.music = 0;
        else
            MusicManager.music = 1;
        //or AudioStatic.music = isOn ? 1 : 0;

        MusicManager.SetInt();
    }
}
