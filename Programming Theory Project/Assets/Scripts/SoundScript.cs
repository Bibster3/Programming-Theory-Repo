using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundScript : MonoBehaviour
{
    private MusicManager music;
    public Button musicToggleButton;
    public Sprite musicOnSprite;
    public Sprite musicOffSprite; 
    // Start is called before the first frame update
    void Start()
    {
        music = GameObject.FindObjectOfType<MusicManager>();
        UpdateIcon();
        
    }
    public void PauseMusic()
    {
        music.ToggleMusic();
        UpdateIcon();
    }



     void UpdateIcon()
    {
        if (PlayerPrefs.GetInt("Muted", 0)==0)
        {
            AudioListener.volume = 0.5f;
            musicToggleButton.GetComponent<Image>().sprite = musicOnSprite;

        }
        else
        {
            AudioListener.volume = 0;
            musicToggleButton.GetComponent<Image>().sprite = musicOffSprite;

        }

    }

    // Update is called once per frame
   
}
