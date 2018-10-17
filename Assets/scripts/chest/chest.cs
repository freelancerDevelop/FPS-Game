using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chest : MonoBehaviour {
    public GameObject ui;
    public bool canOpenUi;
    public bool giveGold;
    bool giveItem;

    public Image Image;
    public float fillAmoutImage;

    public GameObject goldPickUp;
    public Transform spawnItems;
   // public GameObject itemPickUp;



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Image.fillAmount >= 1)
            openChest();

        if (canOpenUi && Input.GetKey(KeyCode.F))
        {
            Image.fillAmount += fillAmoutImage * Time.deltaTime;
        }
        if (Input.GetKeyUp(KeyCode.F))
        {
            Image.fillAmount = 0f;
        }
	}
    private void OnTriggerEnter(Collider other)
    {
        ui.SetActive(true);
        canOpenUi = true;
    }
    private void OnTriggerExit(Collider other)
    {
        ui.SetActive(false);
        canOpenUi = false;
        Image.fillAmount = 0f;

    }
    void openChest()
    {
        ui.SetActive(false);
        canOpenUi = false;
        Image.fillAmount = 0f;
        if (giveGold)
        {
            Instantiate(goldPickUp, spawnItems.position, spawnItems.rotation);
        }
        if (giveItem)
        {

        }
    }
}
