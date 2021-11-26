using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InstructionMenu: MonoBehaviour
{
    public void Start()
    {
        GameObject.FindGameObjectWithTag("Music").GetComponent<MusicPlayer>().PlayMusic();

    }


}
