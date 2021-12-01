using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicManager : MonoBehaviour
{

    public static MusicManager instance = null;


    private void Awake()
    {

        if (instance != null)
        {
            Destroy(gameObject);
        }
       else {
            instance = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }

    }




    public void ToggleMusic()
    {
        if(PlayerPrefs.GetInt("Muted", 0) == 0)
        {
            PlayerPrefs.SetInt("Muted", 1); 
            //AudioListener.volume=1; 
        }
        else
        {
            PlayerPrefs.SetInt("Muted", 0);
            //AudioListener.volume=0; 

        }

    }
}
