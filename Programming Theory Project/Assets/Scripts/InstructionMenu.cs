using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionMenu: MonoBehaviour
{
    RectTransform rectTransform;

    Vector3 initialPosition;
    Vector3 positionAfterClick;
    public float t = 1.0f;
 

    public void Start()
    {
        rectTransform = GetComponent<RectTransform>();


    }
    public void InstructionsMoveUp()
    {
        rectTransform.transform.position =  Vector3.Lerp(initialPosition, positionAfterClick, t);
       
     
    } // Start is called before the first frame update

}
