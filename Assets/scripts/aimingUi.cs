using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class aimingUi : MonoBehaviour {

    public GameObject uiNotAim;
    public GameObject uiAim;
    public RectTransform uiWalkAim;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            aiming();
            
        }
        if(Input.GetKeyUp(KeyCode.Mouse1))
        {
            notAiming();
        }
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
        {
            walkingNotAiming();
        }
        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D))
        {
            notWalking();
        }
    }
    void aiming()
    {
        uiAim.SetActive(true);
        uiNotAim.SetActive(false);

    }
    void notAiming()
    {
        uiAim.SetActive(false);
        uiNotAim.SetActive(true);
    }
    void walkingNotAiming()
    {
        uiWalkAim.sizeDelta = new Vector2(150, 150);
    }
    void notWalking()
    {
        uiWalkAim.sizeDelta = new Vector2(100, 100);

    }
}
