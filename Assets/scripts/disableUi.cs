using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disableUi : MonoBehaviour {

    public float disableTimer;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        disableTimer -= Time.deltaTime;
        if (disableTimer <= 0f)
            Destroy(gameObject);
	}
}
