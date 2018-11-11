using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelFinished : MonoBehaviour {

    public GameObject ui;
    public GameObject currentSliderUi;

    public int addComplete;
    public int addXp;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            player2completion.currentComplete += addComplete;
            player2completion.currentXp += addXp;

            ui.SetActive(true);
            currentSliderUi.SetActive(true);

        }
    }
}
