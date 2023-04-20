using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallFromGround : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("triggered"+ GetComponent<Collider>().gameObject);
    }

    private void OnTriggerExit(Collider other)
    {
        //Debug.Log("left triggered"+ other);
        // if (other.gameObject.CompareTag("Player"))
        // {
        //     // End the game by reloading the current scene
        //      SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        // }
    }
}
