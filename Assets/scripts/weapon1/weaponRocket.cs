using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponRocket : MonoBehaviour {
    public Rigidbody rocketPrefab;
    public Transform barrelEnd;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
           // Rigidbody rocketInstance;
            Instantiate(rocketPrefab, barrelEnd.position, barrelEnd.rotation);
            rocketPrefab.AddForce(barrelEnd.forward * 5000);
        }
	}
}
