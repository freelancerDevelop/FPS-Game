using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rbAddForce : MonoBehaviour {
    Rigidbody rb;
    public float thrust = 1000;
    Transform barrel;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        barrel = transform.Find("rocketbarrel");
	}
	
	// Update is called once per frame
	void Update () {
        rb.AddForce(transform.forward * thrust);
        
	}
}
