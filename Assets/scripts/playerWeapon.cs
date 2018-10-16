using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class playerWeapon : MonoBehaviour {

    public float damage = 10f;
    public float abilityQdamage = 100f;
    public float ability2damage = 100f;


    public float range = 100f;
    public float fireRate = 15f;
    public float impactForce = 30f;

    public ParticleSystem muzzleFlash;
    public ParticleSystem[] muzzleFlashQAbility;



    public Image abilityQImage;
    public Text abilityQTimerText;
    public float abilityQTimer;
    public float abilityQTimerReset;
    public float requiredEnergyQAbility;

    public GameObject ability2;
    public Image ability2Image;
    public float ability2Timer;
    public float ability2TimerReset;
    public float requiredEnergy2Ability;


    public Camera fpsCam;
    float nextTimeToFire = 0f;

	// Use this for initialization
	void Start () {

	}

	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Fire1") && Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1f / fireRate;
            Shoot();

        }
        if (Input.GetKeyDown(KeyCode.Q) && abilityQTimer == 10f)
        {
            if(player1.playerEnergy > requiredEnergyQAbility)
            Ability1();
        }
        abilityQTimer += Time.deltaTime;
        ability2Timer += Time.deltaTime;


        if (abilityQTimer > 10f)
            abilityQTimer = 10f;

        if (ability2Timer > 10f)
            ability2Timer = 10f;

        AbilityResetUi();

        if (Input.GetKeyDown(KeyCode.R) && ability2Timer == 10f)
        {
            if (player1.playerEnergy > requiredEnergy2Ability)
                Ability2();
        }
    }
    void Shoot()
    {
        muzzleFlash.Play();

        RaycastHit hit;
        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            Enemy enemy = hit.transform.GetComponent<Enemy>();
                if(enemy != null)
            {
                enemy.TakeDamage(damage);
            }
                if(hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * impactForce);
            }
        }
    }
    void Ability1()
    {
        muzzleFlashQAbility[0].Play();
        player1.playerEnergy -= requiredEnergyQAbility;


        abilityQTimer = abilityQTimerReset;
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            Enemy enemy = hit.transform.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.TakeDamage(abilityQdamage);
            }
            if (hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * impactForce);
            }
        }

    }
    void Ability2()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            ability2Timer = ability2TimerReset;
            Debug.Log(hit.transform.name);
            Enemy enemy = hit.transform.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.TakeDamage(abilityQdamage);
                Instantiate(ability2, enemy.transform.position, enemy.transform.rotation);
            }
            if (hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * impactForce);
            }
        }
    }
    void AbilityResetUi()
    {
        abilityQImage.fillAmount = abilityQTimer / 10f;
        ability2Image.fillAmount = ability2Timer / 10f;

    }
}

