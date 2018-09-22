﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class player1 : MonoBehaviour {
    public float playerHealth;
    public float maxPlayerHealth;
    public float restoreHealthValue;
    public Text playerHealthText;

    public float playerEnergy;
    public float maxPlayerEnergy;
    public float restoreEnergyValue;

    public Slider playerHealthSlider;
    public Slider playerEnergySlider;


    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        playerHealthText.text = playerHealth.ToString("F1");
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
        if(playerHealth < maxPlayerHealth)
        {
            restoreHealthValue = maxPlayerHealth / maxPlayerHealth;
            restoreEnergyValue = maxPlayerEnergy / maxPlayerEnergy;

            restoreHealth();
        }
        if(playerHealth >= maxPlayerHealth)
        {
            playerHealth = maxPlayerHealth;
        }
        if(playerEnergy >= maxPlayerEnergy)
        {
            playerEnergy = maxPlayerEnergy;
        }
        Debug.Log("health is " + playerHealth);
    }
    void restoreHealth()
    {
        playerHealth += restoreHealthValue * Time.deltaTime;
        playerEnergy += restoreEnergyValue * Time.deltaTime;

    }
}
