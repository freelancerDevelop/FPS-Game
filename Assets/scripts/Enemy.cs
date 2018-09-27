using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Enemy : MonoBehaviour {

    public float health = 50f;
    public Slider healthSlider;
    public GameObject enemyRagdoll;
	// Use this for initialization
	void Start () {
        healthSlider.maxValue = health;
    }
	
	// Update is called once per frame
	void Update () {
        healthSlider.value = health;
	}
    public void TakeDamage(float amoumt)
    {
        health -= amoumt;
        if(health <= 0f)
        {
            Die();
        }
    }
    void Die()
    {
        Instantiate(enemyRagdoll, transform.position, transform.rotation);

        Destroy(gameObject);
    }
}
