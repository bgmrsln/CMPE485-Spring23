using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class DoorScript : MonoBehaviour
{
	public float doorOpenAngle = 90f;
    public float doorCloseAngle = 0f;
    public float smooth = 1f;
    private bool open = false;
 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
    	

        if (collision.gameObject.CompareTag("Key"))
        {
        	Debug.Log("Collision2");
            // Rotate the door open
            if (open == false)
            {

            	Debug.Log("transformRotation" + transform.rotation);
                //Quaternion targetRotation = Quaternion.Euler(doorOpenAngle, doorOpenAngle, doorOpenAngle);
                //transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, smooth * Time.deltaTime);
                Vector3 movementVector = new Vector3(0,0,3) ;
                transform.Translate(movementVector, Space.Self);
                open = true;
              
          
            }

            // End the game after a delay
            Invoke("EndGame", 5f);
        }

       
	       
    	
    
    }
    void EndGame()
    {
        // Reload the initial scene
        SceneManager.LoadScene(0);
    }
}
