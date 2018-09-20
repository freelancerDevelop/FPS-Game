using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openDoor : MonoBehaviour {

    public GameObject door;
    public Transform standardPosition;
    public Transform openPosition;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            // door.SetActive(false);
            transform.localPosition = openPosition.position;
            Debug.Log("door open");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            //  door.SetActive(true);
            transform.localPosition = standardPosition.position;
            Debug.Log("door closed");

        }
    }
}
