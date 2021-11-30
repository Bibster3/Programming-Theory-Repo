using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dontdestroy : MonoBehaviour
{
    private Dontdestroy instance;
    // Start is called before the first frame update
    void Awake()
    {
       
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
