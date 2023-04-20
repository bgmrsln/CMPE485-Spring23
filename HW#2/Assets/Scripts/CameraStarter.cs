using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStarter : MonoBehaviour
{
	[SerializeField] private GameObject objectToFollow;
    [SerializeField] private float xOffset = 0f;
    [SerializeField] private float yOffset = 5f;
    [SerializeField] private float zOffset = -40f;
    private Quaternion camRot;
    public bool isFollowingObject = false;
    // Start is called before the first frame update
    void Start()
    {
    	camRot= Camera.main.transform.rotation;
        
    }
    void Update()
    {
    	if (Input.GetKeyDown(KeyCode.R))
        {
        
        	isFollowingObject = false;
        }
        
    }
    // Update is called once per frame
    void LateUpdate()
    {
    	if (objectToFollow != null && !isFollowingObject)
        {
            // Check if the object has hit the floor
            if (objectToFollow.transform.position.y <= 0.5f)
            {
                // Set the camera position to follow the object
                Vector3 position = objectToFollow.transform.position + new Vector3(xOffset, yOffset, zOffset);
                Camera.main.transform.position = position;
                //Camera.main.transform.rotation = Quaternion.identity;
                Camera.main.transform.SetParent(objectToFollow.transform);
                Camera.main.transform.LookAt(objectToFollow.transform.position);

                //Camera.main.transform.rotation= camRot;
                isFollowingObject = true;
            }
        }
        
    }
}
