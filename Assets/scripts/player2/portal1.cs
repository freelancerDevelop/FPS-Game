using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portal1 : MonoBehaviour {

    public GameObject player;
    public Transform otherPortal;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            player.transform.position = otherPortal.transform.position;
            player.transform.localRotation = otherPortal.transform.localRotation;

        }
    }
}
