using UnityEngine;
using System.Collections;

public class player1Animations : MonoBehaviour
{
    public float controlSpeed;
  
    Animator anim;
    public Transform aimPosition;
    public Transform standardPosition;
    public Transform currentPosition;
    public float timerAnimation;
    public float timerAnimationReset;




    void Start()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        
        anim.SetFloat("Speed", controlSpeed);
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
            controlSpeed = 0.8f;
            
        }
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            controlSpeed = 0;
            
        }
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            playerAim();
            controlSpeed = 1;

        }
        if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            playerStopAim();
            controlSpeed = 0;

        }
        if (Input.GetKeyUp(KeyCode.R))
        {
            anim.SetTrigger("Reloading");
            timerAnimation = timerAnimationReset;
        }

        timerAnimation -= Time.deltaTime;

        if(timerAnimation > 0)
        {
            playerWeapon.isReloading = true;
        }
        if (timerAnimation < 0f)
        {
            timerAnimation = 0f;
            playerWeapon.isReloading = false;

        }
        Debug.Log("timerAnimation " + timerAnimation);
    }
    public void playerAim()
    {
        transform.localPosition = aimPosition.localPosition;
    }
    public void playerStopAim()
    {
        transform.localPosition = standardPosition.localPosition;

    }
    
}