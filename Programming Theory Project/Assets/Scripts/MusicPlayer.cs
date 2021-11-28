using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MusicPlayer : MonoBehaviour
{
    private AudioSource _audioSource;
    private GameObject[] other;
    private bool NotFirst = false;
  
   


    private void Awake()
    {
           
        
        other = GameObject.FindGameObjectsWithTag("Music");


        foreach (GameObject oneOther in other)
        {
            if (oneOther.scene.buildIndex == -1)
            {
                NotFirst = true;
            }
        }

        if (NotFirst == true)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(transform.gameObject);
        _audioSource = GetComponent<AudioSource>();
     
    }

 


    public void ToggleMusic()
    {
        if (_audioSource.mute == true)
        {
            _audioSource.mute = false;
            PlayerPrefs.SetInt("Mute", 1); 

        }
        if (_audioSource.mute == false)
        {
            _audioSource.mute = true;
            PlayerPrefs.SetInt("Mute", 0);
        }

       
    }
 
}
