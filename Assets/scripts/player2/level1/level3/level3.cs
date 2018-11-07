using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level3 : MonoBehaviour {

    public static int level3iteractable = 0;
    public int level3iteractableNeeded;
    public GameObject level3door;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if(level3iteractable >= level3iteractableNeeded)
        {
            level3door.SetActive(false);
        } else
        {
            level3door.SetActive(true);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "cube1")
        {
            level3iteractable++;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "cube1")
        {
            level3iteractable--;
        }
    }
}
