﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour {

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void ChangeSceneLevel1()
    {
        SceneManager.LoadSceneAsync("map1");
    }
    public void ChangeSceneStartMenu()
    {
        SceneManager.LoadSceneAsync("startMenu");
    }
    public void ChangeSceneStartLevel2()
    {
        SceneManager.LoadSceneAsync("map3");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
