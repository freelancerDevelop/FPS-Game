using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player2completion : MonoBehaviour {

    public static int currentComplete = 0;
    public static int maxComplete = 100;

    public static int currentXp = 0;
    public static int maxXp = 100;

    public static int currentCollectibles = 0;
    public int maxCollectibles;

    public Text currentCollectedText;
    public Text maxCollectedText;

    public Slider currentCompleteSlider;
    public Slider currentXpSlider;
    public Slider currentCollectiblesSlider;





    public Slider completeSlider;
	// Use this for initialization
	void Start () {
        completeSlider.maxValue = maxComplete;

    }

    // Update is called once per frame
    void Update () {

        currentCompleteSlider.maxValue = maxComplete;
        currentCompleteSlider.value = currentComplete;

        currentXpSlider.maxValue = maxXp;
        currentXpSlider.value = currentXp;

        currentCollectiblesSlider.maxValue = maxCollectibles;
        currentCollectiblesSlider.value = currentCollectibles;





        currentCollectedText.text = currentCollectibles.ToString();
        maxCollectedText.text = maxCollectibles.ToString();

        completeSlider.value = currentComplete;
        if (currentComplete >= maxComplete)
        {
            currentComplete = maxComplete;
        }

        if (currentComplete <= 0)
        {
            currentComplete = 0;
        }

        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            currentComplete += 10;
        }

        if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            currentComplete -= 10;
        }
    }
}
