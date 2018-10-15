using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthPickUp : MonoBehaviour
{
    public float addHealth;
    public bool continueAddHealth;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            player1.playerHealth += addHealth;
            if (!continueAddHealth)
            {
                Destroy(gameObject);
            }
        }
    }
}