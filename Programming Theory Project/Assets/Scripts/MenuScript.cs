using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    [SerializeField] RectTransform fader;

    private void Start()
    {
        fader.gameObject.SetActive(true);
        LeanTween.alpha(fader,1,0);
        LeanTween.alpha(fader, 0, 0.5f).setOnComplete(() => {
            fader.gameObject.SetActive(false); 
            });

    }
    public void PlayGame()
    {
        fader.gameObject.SetActive(true);
        LeanTween.alpha(fader, 0, 0);
        LeanTween.alpha(fader, 1, 0.5f).setOnComplete(() => {
            SceneManager.LoadScene(0);
        });
        
    }

    public void GoToMenu()
    {
        fader.gameObject.SetActive(true);
        LeanTween.alpha(fader, 0, 0);
        LeanTween.alpha(fader, 1, 0.5f).setOnComplete(() => {
            SceneManager.LoadScene(1);
        });
    }
    public void LoadRules()
    {
        fader.gameObject.SetActive(true);
        LeanTween.alpha(fader, 0, 0);
        LeanTween.alpha(fader, 1, 0.5f).setOnComplete(() => {
            SceneManager.LoadScene(2);
        });
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        fader.gameObject.SetActive(true);
        LeanTween.alpha(fader, 0, 0);
        LeanTween.alpha(fader, 1, 0.5f).setOnComplete(() => {
            Application.Quit();
        });
        
    }

}

