using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disappear : MonoBehaviour
{
	public float disappearTime = 2f;
    public float appearTime = 2f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DisappearAndAppear());
    }


    IEnumerator DisappearAndAppear()
    {
        while (true)
        {
            // Disappear the floor
            gameObject.SetActive(false);
            Debug.Log("Floor disappeared");
            yield return new WaitForSeconds(disappearTime);

            // Reappear the floor
            gameObject.SetActive(true);
            Debug.Log("Floor reappeared");
            yield return new WaitForSeconds(appearTime);
        }
    }
}
