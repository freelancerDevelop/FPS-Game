using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class player1 : MonoBehaviour {
    public float playerHealth;
    public float maxPlayerHealth;
    public float playerEnergy;
    public float maxPlayerEnergy;
    public Slider playerHealthSlider;
    public Slider playerEnergySlider;


    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        playerHealthSlider.maxValue = maxPlayerHealth;
        playerHealthSlider.value = playerHealth;

        playerEnergySlider.maxValue = maxPlayerEnergy;
        playerEnergySlider.value = playerEnergy;

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            playerHealth -= 10;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            playerHealth += 10;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            playerEnergy -= 10;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            playerEnergy += 10;
        }

    }
}
