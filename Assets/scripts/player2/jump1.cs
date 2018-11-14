using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump1 : MonoBehaviour {

    public Rigidbody rigidbody;
    public float thrust;

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
            playerJump();
            Debug.Log("on trigger enter");
        }
    }
    void playerJump()
    {
        rigidbody.AddForce(0, 0, thrust, ForceMode.Impulse);
    }
}
