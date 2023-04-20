using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
	public float rotateSpeed = 90f; // the speed at which the door rotates
    public GameObject keyObject; // the key object that triggers the door to open


    private bool isOpen = false; // a flag to indicate whether the door is currently open
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
        // check if the collision was with the key object
        if (collision.gameObject == keyObject)
        {
            // if the door is not already open, rotate it open
            if (!isOpen)
            {
                transform.Rotate(0, 90, 0);
                isOpen = true;
            }
            // if the door is already open, end the game
            else
            {
                Application.Quit();
            }
        }
    }
}
