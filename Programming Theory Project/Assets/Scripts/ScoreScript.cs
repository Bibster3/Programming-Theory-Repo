using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    Renderer[] children;
    private AudioSource scoreSound; 

    public void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        scoreSound = other.GetComponentInChildren<AudioSource>();
        children = other.GetComponentsInChildren<Renderer>();

        foreach (Renderer rend in children)
        {
            StartCoroutine(SwitchColor(rend));

          }

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
        scoreSound.Play(); 

        Debug.Log("TriggerHit " + UIScript.Score);

    }
    System.Collections.IEnumerator SwitchColor(Renderer renderer)
    {
        Color color = renderer.material.color;
        renderer.material.color = Color.green;
        yield return new WaitForSeconds(0.2f);
        renderer.material.color = Color.white;
    }


}
