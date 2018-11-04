using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2inventory : MonoBehaviour {

    public GameObject gravityGun;
    public GameObject gravityGunUi;
    public bool hasGravityGun;
    public int currentEquipedItem;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (hasGravityGun && currentEquipedItem == 2)
        {
            gravityGun.SetActive(true);
            gravityGunUi.SetActive(true);

        } else
        {
            gravityGun.SetActive(false);
            gravityGunUi.SetActive(false);
        }
    }
}
