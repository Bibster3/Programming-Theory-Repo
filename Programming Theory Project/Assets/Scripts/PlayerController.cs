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
        arrow = GameObject.FindGameObjectWithTag("Arrow");
        circle = GameObject.FindGameObjectWithTag("Circle");
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

        ArrowAndCircleBehaviour();

        shootPower = Mathf.Abs(safeSpace) * 13;
        Vector3 dimentionxz = mousePointA.transform.position - transform.position;
        float difference = dimentionxz.magnitude;
        mousePointB.transform.position = transform.position + ((dimentionxz / difference) * currentDistance * -1); //not to move outside the boundarues 
        mousePointB.transform.position = new Vector3(mousePointB.transform.position.x, -0.5f, mousePointB.transform.position.z);

        shootDirection = Vector3.Normalize(mousePointA.transform.position - transform.position); 
    }

    void OnMouseUp()
    {
        arrow.GetComponent<Renderer>().enabled = false;
        circle.GetComponent<Renderer>().enabled = false;
        Vector3 push = shootDirection * shootPower * -1;
        GetComponent<Rigidbody>().AddForce(push, ForceMode.Impulse);

    }

    private void ArrowAndCircleBehaviour()
    {
        arrow.GetComponent<Renderer>().enabled = true;
        circle.GetComponent<Renderer>().enabled = true;

        //calc position 

        if (currentDistance <= maxDistance)
        {
            arrow.transform.position = new Vector3((2 * transform.position.x) - mousePointA.transform.position.x, -1.5f, (2 * transform.position.z) - mousePointA.transform.position.z); 
        }

        else
        {
            Vector3 dimentionxz = mousePointA.transform.position - transform.position;
            float difference = dimentionxz.magnitude;
            arrow.transform.position = transform.position + ((dimentionxz / difference) * maxDistance * -1); //not to move outside the boundarues 
            arrow.transform.position = new Vector3(arrow.transform.position.x, -1.5f, arrow.transform.position.z);

        }

        circle.transform.position = transform.position + new Vector3(0, 0.05f, 0);
        Vector3 direction = mousePointA.transform.position - transform.position;
        float rotation;
        if (Vector3.Angle(direction, transform.forward)>90)
        {
            rotation = Vector3.Angle(direction, transform.right);

        }
        else
        {
            rotation = Vector3.Angle(direction, transform.right)*-1; 
        }

        arrow.transform.eulerAngles = new Vector3(0, rotation, 0);

        float scaleX = Mathf.Log(1 + safeSpace / 2, 2) * 2.2f;
        float scaleZ = Mathf.Log(1 + safeSpace / 2, 2) * 2.2f;

        arrow.transform.localScale = new Vector3(1 + scaleX, 0.001f, 1 + scaleZ);
        circle.transform.localScale = new Vector3(1 + scaleX, 0.001f, 1 + scaleZ);

    }
}
