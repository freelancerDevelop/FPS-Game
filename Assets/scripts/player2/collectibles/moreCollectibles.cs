using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moreCollectibles : MonoBehaviour {

    public int addXp;
    public int completitionAdd;
    public GameObject currentXpSlider;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            player2completion.currentCollectibles++;
            player2completion.currentXp += addXp;
            player2completion.currentComplete += completitionAdd;
            currentXpSlider.SetActive(true);

        }
    }
}
