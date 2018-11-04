using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level1 : MonoBehaviour {

    public GameObject laser;
    public bool cubeisOn;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (cubeisOn)
        {
            laser.SetActive(false);
        } else
        {
            laser.SetActive(true);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "cube1")
        {
            cubeisOn = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "cube1")
        {
            cubeisOn = false;
        }
    }
}
