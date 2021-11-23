using UnityEngine;

public class DiscScript : MonoBehaviour
{
    public GameObject discPrefab;
    public GameObject discLounchPosition;
   
    public float speed = 0.18f;
    float minX = -0f;
    float maxX = 1.66f;
    float horizontalAxis;
    Vector3 moveDirection;
    private float z = -3.5f;
  

    private void Start()
    {

       
    }



    void Update()
    {
        
        horizontalAxis = Input.GetAxis("Horizontal");
        moveDirection = new Vector3(horizontalAxis, 0.0f, 0.0f);
        transform.position += moveDirection * speed;
       transform.position = new Vector3(Mathf.Clamp(transform.position.x, minX, maxX), transform.position.y, z);
         
        if (Input.GetKeyDown(KeyCode.Space) && (UIScript.Hits > 0))
        {
            Shoot();
        }
      
    }



    private void Shoot()
    {

        var newDisc = Instantiate(discPrefab);
        newDisc.SetActive(true);
        newDisc.transform.position = discLounchPosition.transform.position;
        newDisc.transform.rotation = discLounchPosition.transform.rotation;
        var discRigidbody = newDisc.GetComponent<Rigidbody>();
        discRigidbody.AddRelativeForce(Vector3.forward * 15f, ForceMode.Impulse);
        Debug.Log("Shoot " + UIScript.Hits + "Score " + UIScript.Score);
        UIScript.Hits--; 

    }
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}





