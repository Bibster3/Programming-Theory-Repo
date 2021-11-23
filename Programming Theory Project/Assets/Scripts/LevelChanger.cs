
using UnityEngine;

public class LevelChanger : MonoBehaviour
{
    // Start is called before the first frame update

    public Animator animator; 
    // Update is called once per frame
    void Update()
    {
        
    }

    public void FadeToLevel()
    {
        animator.SetTrigger("FadeOut");


    }
}
