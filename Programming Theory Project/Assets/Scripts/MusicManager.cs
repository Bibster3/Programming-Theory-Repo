using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicManager : MonoBehaviour
{

    public static int music;

    public static MusicManager instance;

    private void Awake()
    {
        music = PlayerPrefs.GetInt("Music");

        gameObject.transform.parent = null;
        DontDestroyOnLoad(transform.gameObject);

       if (instance == null)
        {
           
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
            return;

        }
    }

    void Start()
    {
        music = PlayerPrefs.GetInt("Music");

        Debug.Log("music: " + music);
    }

    public static void SetInt()
    {
        PlayerPrefs.SetInt("Music", music);
    }
}
