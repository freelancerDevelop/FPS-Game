using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goldPick : MonoBehaviour {

    public int addGold;
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
            player1.player1Gold += addGold;
            Destroy(gameObject);
        }
    }
}
