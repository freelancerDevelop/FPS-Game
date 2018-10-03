using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAchievements : MonoBehaviour {

    public GameObject achievement1;
    int achievement1Score = 0;
    public int achievement1ScoreNeeded;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(achievement1Score == achievement1ScoreNeeded)
        {
            achievement1made();
        }
	}
    public void achievement1made()
    {
        achievement1.SetActive(true);
    }
    public void achievement1Progress()
    {
        achievement1Score++;
    }
}
