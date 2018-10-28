using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chestDestroy : MonoBehaviour {
    public float health = 50f;
    public GameObject spawnPrefab;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void TakeDamage(float amoumt)
    {
        int getDamageTextActive = Random.Range(0, 5);
       // getDamage[getDamageTextActive].SetActive(true);
        health -= amoumt;
        if (health <= 0f)
        {
            Die();
        }
    }
    void Die()
    {
       // Instantiate(enemyRagdoll, spawnRagdoll.transform.position, spawnRagdoll.transform.rotation);
        Instantiate(spawnPrefab, gameObject.transform.position, spawnPrefab.transform.rotation);


        Destroy(gameObject);
       // OnDied.Invoke();
    }
}
