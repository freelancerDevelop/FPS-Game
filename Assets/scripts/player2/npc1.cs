using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc1 : MonoBehaviour {

    public GameObject ui;
    public GameObject ui2;
    public bool canShow;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (canShow && Input.GetKeyUp(KeyCode.F))
        {
            ui2.SetActive(true);
        }
        if (!canShow)
        {
            ui2.SetActive(false);
        }
	}
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            ui.SetActive(true);
            canShow = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            ui.SetActive(false);
            canShow = false;
        }
    }
}
