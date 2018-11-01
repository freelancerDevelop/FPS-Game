using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerInventory : MonoBehaviour {

    public GameObject[] weaponType1;

    public GameObject[] weaponType2;

    public GameObject[] weaponType3;

    public GameObject[] weaponType;

    public int weaponTypeEquip;

    public int[] weaponEquipType;

    public GameObject ui1;
    

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            weaponTypeEquip = 1;
            ui1.SetActive(true);
        }
        else if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            weaponTypeEquip = 2;
            ui1.SetActive(true);
        }
        else if (Input.GetKeyUp(KeyCode.Alpha3))
        {
            weaponTypeEquip = 3;
            ui1.SetActive(false);
        }
        switch (weaponEquipType[0])
        {
            case 1:
                weaponType1[0].SetActive(true);
                weaponType1[1].SetActive(false);
                weaponType1[2].SetActive(false);
                break;
            case 2:
                weaponType1[1].SetActive(true);
                weaponType1[0].SetActive(false);
                weaponType1[2].SetActive(false);
                break;
            case 3:
                weaponType1[2].SetActive(true);
                weaponType1[0].SetActive(false);
                weaponType1[1].SetActive(false);
                break;
            default:
                Debug.Log("no weapon type 1");
                break;
        }

        switch (weaponEquipType[1])
        {
            case 1:
                weaponType2[0].SetActive(true);
                weaponType2[1].SetActive(false);
                weaponType2[2].SetActive(false);
                break;
            case 2:
                weaponType2[1].SetActive(true);
                weaponType2[0].SetActive(false);
                weaponType2[2].SetActive(false);
                break;
            case 3:
                weaponType2[2].SetActive(true);
                weaponType2[0].SetActive(false);
                weaponType2[1].SetActive(false);
                break;
            default:
                Debug.Log("no weapon type 2");
                break;
        }

        switch (weaponEquipType[2])
        {
            case 1:
                weaponType3[0].SetActive(true);
                weaponType3[1].SetActive(false);
                weaponType3[2].SetActive(false);
                break;
            case 2:
                weaponType3[1].SetActive(true);
                weaponType3[0].SetActive(false);
                weaponType3[2].SetActive(false);
                break;
            case 3:
                weaponType3[2].SetActive(true);
                weaponType3[0].SetActive(false);
                weaponType3[1].SetActive(false);
                break;
            default:
                Debug.Log("no weapon type 3");
                break;
        }
        switch (weaponTypeEquip)
        {
            case 1:
                weaponType[0].SetActive(true);
                weaponType[1].SetActive(false);
                weaponType[2].SetActive(false);
                break;
            case 2:
                weaponType[1].SetActive(true);
                weaponType[0].SetActive(false);
                weaponType[2].SetActive(false);
                break;
            case 3:
                weaponType[2].SetActive(true);
                weaponType[0].SetActive(false);
                weaponType[1].SetActive(false);
                break;
        }
	}
    public void equipWeaponType1Weapon1()
    {
        weaponEquipType[0] = 1;
    }
    public void equipWeaponType1Weapon2()
    {
        weaponEquipType[0] = 2;
    }
    public void equipWeaponType1Weapon3()
    {
        weaponEquipType[0] = 3;
    }


}
