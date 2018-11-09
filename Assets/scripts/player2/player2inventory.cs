using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2inventory : MonoBehaviour {

    public GameObject gravityGun;
    public GameObject gravityGunUi;
    public bool hasGravityGun;
    public int currentEquipedItem;
    public GameObject portalGun;
    public GameObject portalGunUi;
    public bool hasPortalGun;
    public GameObject moveGun;
    public GameObject moveGunUi;
    public bool hasMoveGun;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (hasGravityGun && currentEquipedItem == 1)
        {
            gravityGun.SetActive(true);
            gravityGunUi.SetActive(true);

        } else
        {
            gravityGun.SetActive(false);
            gravityGunUi.SetActive(false);
        }

        if (hasPortalGun && currentEquipedItem == 2)
        {
            portalGun.SetActive(true);
            portalGunUi.SetActive(true);

        }
        else
        {
            portalGun.SetActive(false);
            portalGunUi.SetActive(false);
        }

        if (hasMoveGun && currentEquipedItem == 3)
        {
            moveGun.SetActive(true);
            moveGunUi.SetActive(true);

        }
        else
        {
            moveGun.SetActive(false);
            moveGunUi.SetActive(false);
        }

        if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            currentEquipedItem = 1;
        }

        if (Input.GetKeyUp(KeyCode.Alpha3))
        {
            currentEquipedItem = 2;
        }

        if (Input.GetKeyUp(KeyCode.R))
        {
            currentEquipedItem = 3;
        }
    }
    public void equipGravityGun()
    {
        hasGravityGun = true;
    }
    public void equipPortalGun()
    {
        hasPortalGun = true;
    }
}
