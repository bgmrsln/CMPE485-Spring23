using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move : MonoBehaviour
{
	[SerializeField]
    
    private Vector3 startPos;
    //[SerializeField] private float intensity= 1f;

    //private Rigidbody rb;
    public float rotationSpeed = 30f;
    public float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
    	float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        if (horizontalInput != 0 || verticalInput != 0)
        {
	            // Calculate the movement amount based on the speed and the vertical input value
	        float movementAmount = speed * Time.deltaTime * verticalInput;

	        // Calculate the movement vector based on the movement amount and the object's forward vector
	        Vector3 movementVector = Vector3.right* movementAmount ;

	        // Apply the movement vector to the object's position
	        transform.Translate(movementVector, Space.Self);


            if (horizontalInput != 0f)
        	{
	            // Calculate the rotation amount based on the rotation speed and the time elapsed
	            float rotationAmount = rotationSpeed * Time.deltaTime * horizontalInput;

	            // Rotate the object around its up axis
	            transform.Rotate(Vector3.up, rotationAmount);
        	}
        }
        
        
    }
    void OnCollisionEnter(Collision collision)
    {
    	
    	Debug.Log("collided"+ collision.gameObject);
        
    
    }

    void OnCollisionExit(Collision collision)
    {
    	Debug.Log("left collided"+ collision.gameObject);
    	

        
    
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("triggered"+ other);
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("left triggered"+ other);
        if (other.gameObject.CompareTag("Floor"))
        {
            // End the game by reloading the current scene
             SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
 
    
}
