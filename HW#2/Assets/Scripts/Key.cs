using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour

{
	public GameObject player;
	private bool isPickedUp = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        // Check if the key is picked up
        if (isPickedUp)
        {
            // Move the key along with the player
            transform.position = player.transform.position + new Vector3(-2f, 0f, 0f);

            // Check if the player has released the key
            if (Input.GetKeyDown(KeyCode.Space))
            {
                isPickedUp = false;
                // Remove the player as the parent of the key
                transform.SetParent(null);
                // Enable physics on the key
                Rigidbody rb = GetComponent<Rigidbody>();
                rb.isKinematic = false;
                rb.useGravity = true;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isPickedUp)
        {
            isPickedUp = true;
            // Set the player as the parent of the key
            
        }
    }
}
