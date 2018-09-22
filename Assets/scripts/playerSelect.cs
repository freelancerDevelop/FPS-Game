using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerSelect : MonoBehaviour {

    public string playerSelected;
    public GameObject player1;
    public GameObject player2;
    public GameObject player3;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void player1Selected()
    {
        playerSelected = "player1";
        player1.SetActive(true);
        player2.SetActive(false);
        player3.SetActive(false);

    }
    public void player2Selected()
    {
        playerSelected = "player2";
        player1.SetActive(false);
        player2.SetActive(true);
        player3.SetActive(false);

    }
    public void player3Selected()
    {
        playerSelected = "player3";
        player1.SetActive(false);
        player2.SetActive(false);
        player3.SetActive(true);

    }

}
