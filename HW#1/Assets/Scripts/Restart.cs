using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour

{
	
	[SerializeField] Transform objectsContainer;


	private List<Vector3> spawnPositions;
	private List<Quaternion> spawnRotations;
	
	private Vector3 camPos;
	private Quaternion camRot;
    // Start is called before the first frame update
    void Start()
    {
    	spawnPositions = new List<Vector3>();
    	spawnRotations = new List<Quaternion>();
    
		for (var i = 0; i < objectsContainer.childCount; i++)
		{
			spawnPositions.Add(objectsContainer.GetChild(i).position);
			spawnRotations.Add(objectsContainer.GetChild(i).rotation);
			
		}
		camPos= Camera.main.transform.position;
		camRot= Camera.main.transform.rotation;
        
    }
     void Update()
    {
    	if (Input.GetKeyDown(KeyCode.R))
        {
        
        	ResetAll();
        }
        
    }

    // Update is called once per frame
    public void ResetAll()
	{
		for (var i = 0; i < objectsContainer.childCount; i++)
		{
			Transform tr = objectsContainer.GetChild(i);
			tr.position = spawnPositions[i];
			Debug.Log("Rotation" + spawnRotations[i]);
			tr.rotation = spawnRotations[i];
			tr.GetComponent<Rigidbody>().velocity = Vector3.zero;
		}
		Camera.main.transform.rotation= camRot;
		Camera.main.transform.position= camPos;
	}
}
