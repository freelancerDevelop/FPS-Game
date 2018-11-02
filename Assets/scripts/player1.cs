using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class player1 : MonoBehaviour {
    public static float playerHealth = 100;
    public float maxPlayerHealth;
    public float restoreHealthValue;
    public Text playerHealthText;

    public static float playerEnergy = 100;
    public float maxPlayerEnergy;
    public float restoreEnergyValue;
    public Text playerEnergyText;

    public Slider playerHealthSlider;
    public Slider playerEnergySlider;

    public int playerLevel;
    public int currentXp;
    public int startXp;
    public int requiredXpLevelUp;

    public static int player1Gold = 0;

    public Text levelText;
    public Image levelSlider;
    public Text currentXpText;

    public Slider levelSliderUi;
    public Text levelTextUi;

    public Text player1GoldText;

    public Text player1GoldTextUi;
    public float levelSliderImage;

    public Transform restartLevelTransform;



    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

        if(playerHealth < 0f)
        {
            restartLevel();
        }

        levelSlider.fillAmount = currentXp / 100f;
        levelSliderImage = currentXp / 100f;
        levelSliderUi.value = currentXp;
        levelSliderUi.maxValue = requiredXpLevelUp;

        currentXpText.text = currentXp.ToString();
        levelText.text = playerLevel.ToString();
        levelTextUi.text = playerLevel.ToString();

        player1GoldText.text = player1Gold.ToString();

        player1GoldTextUi.text = player1Gold.ToString();




        if (currentXp >= requiredXpLevelUp)
        {
            playerLevel++;
            currentXp = startXp;

        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            currentXp += 10;
        }

        playerHealthText.text = playerHealth.ToString("F0");
        playerEnergyText.text = playerEnergy.ToString("F0");

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

            restoreHealth();
        }
        if(playerEnergy < maxPlayerEnergy)
        {
            restoreEnergyValue = maxPlayerEnergy / maxPlayerEnergy;
            restoreEnergy();
        }
        if (playerHealth >= maxPlayerHealth)
        {
            playerHealth = maxPlayerHealth;
        }
        if(playerEnergy >= maxPlayerEnergy)
        {
            playerEnergy = maxPlayerEnergy;
        }
    }
    public void givePlayerGold()
    {
        player1Gold += 50;
    }
    public void givePlayerXp()
    {
        currentXp += 50;
    }
    void restoreHealth()
    {
        playerHealth += restoreHealthValue * Time.deltaTime;
    }
    void restoreEnergy()
    {
        playerEnergy += restoreEnergyValue * Time.deltaTime;
    }
    public void restartLevel()
    {
        gameObject.transform.position = restartLevelTransform.transform.position;
        playerHealth = maxPlayerHealth;
        playerEnergy = maxPlayerEnergy;

    }
}
