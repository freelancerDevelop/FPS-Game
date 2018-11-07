using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uienable : MonoBehaviour {

    public GameObject ui1;
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
            ui1.SetActive(true);
        }
    }
}
