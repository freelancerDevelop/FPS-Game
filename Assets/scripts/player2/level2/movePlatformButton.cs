using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class movePlatformButton : MonoBehaviour {

    public UnityEvent movePosition1ToPosition2;
    public UnityEvent movePosition2ToPosition1;

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
            movePosition1ToPosition2.Invoke();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "cube1")
        {
            movePosition2ToPosition1.Invoke();
        }
    }
}
