using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player2completion : MonoBehaviour {

    public int complete;
    public int currentComplete;

    public Slider completeSlider;
    public Slider currentSlider;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        currentSlider.maxValue = complete;
        currentSlider.value = currentComplete;

    }
}
