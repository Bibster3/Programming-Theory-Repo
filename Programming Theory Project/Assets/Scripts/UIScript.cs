using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    public static int Hits;
    public static int Score;
    public Text hitText;
    public Text scoreText;
    public Text gameOverText; 

    // Start is called before the first frame update
    void Start()
    {
        Hits = 30;
        Score = 0;

        gameOverText.gameObject.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score " + Score;
        hitText.text = "Hits Left " + Hits;



        if (Hits==0)
        {
            GameOver(); 
        }

    }
    void GameOver()
    {
        gameOverText.gameObject.SetActive(true);


    }
}
