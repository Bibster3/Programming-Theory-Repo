using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicManager : MonoBehaviour
{

    public static int muted;
    public static MusicManager instance;
    public  Toggle musicButton;
    public AudioSource musicSource;


    private void Awake()
    {
        ToggleButton();

        GetIntMusic();

        if (instance == null)
        {
            instance = this;
            
            DontDestroyOnLoad(instance);
        }
       else {
            Destroy(musicSource); 
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(musicButton.gameObject); 

    }

    private void ToggleButton()
    {
        musicButton = FindObjectOfType<Toggle>();

        if (muted == 1)
        {
            musicButton.GetComponent<Toggle>().isOn = true;
        }
        else if (muted == 0)
        {
            musicButton.GetComponent<Toggle>().isOn = false;
        }
    }

    public static void GetIntMusic()
    {
        muted = PlayerPrefs.GetInt("Music");
    }

    public static void SetIntMusic()
    {
        PlayerPrefs.SetInt("Music", muted);
    }

    public void ToggleMusic()
    {
        bool isOn = musicButton.GetComponent<Toggle>().isOn;
        musicSource.mute = isOn;
        if (isOn)
        {
            muted = 1;
        }
        else
        {
            muted = 0;
        }

       SetIntMusic();
    }
}
