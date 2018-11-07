using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uidisable : MonoBehaviour {

    public float timer;
    public float timerReset;

    // Use this for initialization
    void Start () {
        timer = timerReset;

    }
    void OnEnable()
    {
        timer = timerReset;    
    }

    // Update is called once per frame
    void Update () {
        timer -= Time.deltaTime;
        if(timer <= 0f)
        {
            gameObject.SetActive(false);
        }
	}
}
