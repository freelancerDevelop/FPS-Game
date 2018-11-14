using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enableOnClick : MonoBehaviour {

    public GameObject platform1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "cube1")
        {
            platform1.SetActive(true);
        }
    }
}
