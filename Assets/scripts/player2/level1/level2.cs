using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level2 : MonoBehaviour {

    public GameObject laser1;
    public bool laserIsOn;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if (laserIsOn)
        {
            laser1.SetActive(true);
        } else
        {
            laser1.SetActive(false);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "laser1")
        {
            laserIsOn = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "laser1")
        {
            laserIsOn = false;
        }
    }
}
