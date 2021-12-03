using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private GameObject mousePointA; 
    private GameObject mousePointB; 
    private GameObject arrow; 
    private GameObject circle;

    private float currentDistance;
    public float maxDistance = 3f;
    private float safeSpace;
    private float shootPower;

    private Vector3 shootDirection; 

    private void Awake()
    {
        mousePointA = GameObject.FindGameObjectWithTag("PointA");
        mousePointB = GameObject.FindGameObjectWithTag("PointB");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDrag()
    {
        currentDistance = Vector3.Distance(mousePointA.transform.position, transform.position);

        if (currentDistance<= maxDistance)
        {
            safeSpace = currentDistance; 
        }
        else
        {
            safeSpace = maxDistance;
        }


        shootPower = Mathf.Abs(safeSpace) * 10;
        Vector3 dimentionxy = mousePointA.transform.position - transform.position;
        float difference = dimentionxy.magnitude;
        mousePointB.transform.position = transform.position + ((dimentionxy / difference) * currentDistance * -1); //not to move outside the boundarues 
        mousePointB.transform.position = new Vector3(mousePointB.transform.position.x, mousePointB.transform.position.y, -0.8f); 
    }
}
