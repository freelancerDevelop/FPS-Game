using UnityEngine;
using System.Collections;

public class player1AnimationMelee : MonoBehaviour
{
    public float controlSpeed;
    public bool controlSword1;
    public bool controlSword1Block;


    Animator anim;




    void Start()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {

        anim.SetFloat("Speed", controlSpeed);
        anim.SetBool("sword1", controlSword1);
        anim.SetBool("sword1block", controlSword1Block);


        Debug.Log("controlSpeed is " + controlSpeed);


        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            controlSpeed++;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            controlSpeed--;

        }
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
        {
            controlSpeed = 0.2f;
        }
        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D))
        {
            controlSpeed = 0;
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            controlSpeed = 0.4f;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            controlSpeed = 0;
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            controlSpeed = 0.6f;

        }
        if (Input.GetKeyUp(KeyCode.F))
        {
            controlSpeed = 0;

        }
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            controlSword1 = true;

        }
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            controlSword1 = false;
        }
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            controlSword1 = false;
            controlSword1Block = true;
        }
        if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            controlSword1Block = false;
        }

    }
}