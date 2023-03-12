using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMoveInput : MonoBehaviour
{
    [SerializeField]
    
    private Vector3 startPos;
    [SerializeField] private float intensity= 1f;

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
    	//rb = GetComponent<Rigidbody>();
    	rb = GetComponent<Rigidbody>();
        startPos = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        if (horizontalInput != 0 || verticalInput != 0)
        {
            Vector3 force = new Vector3(horizontalInput*intensity, 0f, verticalInput*intensity);
            rb.AddForce(force);
        }
        

        
    }
}
