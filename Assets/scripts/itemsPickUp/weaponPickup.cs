using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class weaponPickup : MonoBehaviour {

    public GameObject ui;
    bool canGetItem;
    public UnityEvent onEquip;


    // Use this for initialization
    void Start () {


    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.F) && canGetItem == true)
        {
            pickUpWeapon();
        }
	}
    void pickUpWeapon()
    {
        onEquip.Invoke();
        Destroy(gameObject);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            ui.SetActive(true);
            canGetItem = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            ui.SetActive(false);
            canGetItem = false;

        }
    }
}
