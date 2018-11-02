using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class dropPickUp : MonoBehaviour {

    public GameObject dropItem;
    public Transform dropTransform;
    public UnityEvent ondisabled;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnDisable()
    {
        dropPickup();
    }
    public void dropPickup()
    {
        Instantiate(dropItem, dropTransform.transform.position, dropTransform.transform.rotation);
    }
}
