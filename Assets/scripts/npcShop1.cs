using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcShop1 : MonoBehaviour {

    public GameObject ui1;
    public GameObject ui2;
    

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.F))
        {
            openVendor();
        }
	}
    public void openVendor()
    {
        ui2.SetActive(true);

        
    }
    public void closeVendor()
    {
        ui2.SetActive(false);

        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            ui1.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            ui1.SetActive(false);
            ui2.SetActive(false);
            closeVendor();
        }
    }
}
