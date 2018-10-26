using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;


public class Enemy : MonoBehaviour {

    public float health = 50f;
    public Slider healthSlider;
    public GameObject spawnRagdoll;
    public GameObject enemyRagdoll;
    public GameObject spawnPrefab;
    public UnityEvent OnDied;
    public GameObject[] getDamage;
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
        int getDamageTextActive = Random.Range(0, 5);
       getDamage[getDamageTextActive].SetActive(true);
        health -= amoumt;
        if(health <= 0f)
        {
            Die();
        }
    }
    void Die()
    {
        Instantiate(enemyRagdoll, spawnRagdoll.transform.position, spawnRagdoll.transform.rotation);
        Instantiate(spawnPrefab, gameObject.transform.position, spawnPrefab.transform.rotation);


        Destroy(gameObject);
        OnDied.Invoke();
    }
}
