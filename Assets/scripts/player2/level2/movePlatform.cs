using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlatform : MonoBehaviour {

    public GameObject platform1;
    public Transform position1;
    public Transform position2;
    public float speed;

    public bool movePosition1ToPosition2;

    public float timer;
    public float timerReset;



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        timer -= Time.deltaTime;

        if (timer <= 0f)
        {

        }
        if (Input.GetKey(KeyCode.Alpha1))
        {
            MovePosition1ToPosition2();
        }

        if (Input.GetKey(KeyCode.R))
        {
            MovePosition2ToPosition1();
        }

        if (movePosition1ToPosition2)
        {
            MovePosition1ToPosition2();

        } else if (!movePosition1ToPosition2)
        {

                MovePosition2ToPosition1();
        }
    }
    public void MovePosition1ToPosition2()
    {
        platform1.transform.position = Vector3.MoveTowards(platform1.transform.position, position2.position, speed * Time.deltaTime);
    }
    public void MovePosition2ToPosition1()
    {
        platform1.transform.position = Vector3.MoveTowards(platform1.transform.position, position1.position, speed * Time.deltaTime);
    }

    public void GoUp()
    {

        movePosition1ToPosition2 = true;
    }
    public void DontGoUp()
    {
        movePosition1ToPosition2 = false;
    }
}
