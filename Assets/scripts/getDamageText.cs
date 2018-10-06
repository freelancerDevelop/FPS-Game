using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getDamageText : MonoBehaviour {

    float disableTimer;
    public float disableTimerReset;

    // Use this for initialization
    void Start () {

    }
    private void OnEnable()
    {
        disableTimer = disableTimerReset;

    }

    // Update is called once per frame
    void Update () {
        disableTimer -= Time.deltaTime;
        if(disableTimer <= 0f)
        {
            gameObject.SetActive(false);
        }
	}
}
