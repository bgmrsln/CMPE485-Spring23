using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewCube : MonoBehaviour
{
	[SerializeField] private GameObject prefab;
	[SerializeField] private float maxOffset = 1f;
	private Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
    	if (Input.GetKeyDown(KeyCode.C))
        {
        	startPos = startPos+ Random.insideUnitSphere * maxOffset;
            //Create a new instance of the prefab
            Instantiate(prefab, transform.position, Quaternion.identity);
        }
        
    }
}
