using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.tag == "1")
        {

            UIScript.Score = UIScript.Score + 1;
        }

        if (other.gameObject.tag == "2")
        {

            UIScript.Score = UIScript.Score + 2;
        }

        if (other.gameObject.tag == "3")
        {

            UIScript.Score = UIScript.Score + 3;
        }

        if (other.gameObject.tag == "4")
        {

            UIScript.Score = UIScript.Score + 4;
        }
        Debug.Log("TriggerHit " + UIScript.Score);

    }
}
