using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class playerWeapon : MonoBehaviour {

    public float damage = 10f;
    public float abilityQdamage = 100f;
    public float ability2damage = 100f;
    int currentBullets;
    public int maxBullets;
    public Text currentBulletsText;
    public Text maxBulletsText;

    public static bool isReloading = false;


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

    public float playerHealthHeal;
    public ParticleSystem[] ability3;
    public Image ability3Image;
    public float ability3Timer;
    public float ability3TimerReset;
    public float requiredEnergy3Ability;

    public GameObject ability1;
    public GameObject weapon1icon;
    public GameObject lowAmmo;


    public Camera fpsCam;
    float nextTimeToFire = 0f;

	// Use this for initialization
	void Start () {
        currentBullets = maxBullets;
	}
    private void OnEnable()
    {
        ability1.SetActive(true);
        weapon1icon.SetActive(true);

    }
    private void OnDisable()
    {
        ability1.SetActive(false);
        weapon1icon.SetActive(false);

    }


    // Update is called once per frame
    void Update () {

        currentBulletsText.text = currentBullets.ToString();
        maxBulletsText.text = maxBullets.ToString();

        if (currentBullets < 0)
        {
            currentBullets = 0;
        }
        if(Input.GetKeyUp(KeyCode.R))
        {
            weaponReaload();
        }
        if (Input.GetButton("Fire1") && Time.time >= nextTimeToFire && currentBullets > 0 && isReloading == false)
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
        ability3Timer += Time.deltaTime;



        if (abilityQTimer > 10f)
            abilityQTimer = 10f;

        if (ability2Timer > 10f)
            ability2Timer = 10f;

        if (ability3Timer > 10f)
            ability3Timer = 10f;

        AbilityResetUi();

        if (Input.GetKeyDown(KeyCode.G) && ability2Timer == 10f)
        {
            if (player1.playerEnergy > requiredEnergy2Ability)
                Ability2();
        }
        if (Input.GetKeyDown(KeyCode.E) && ability3Timer == 10f)
        {
            if (player1.playerEnergy > requiredEnergy3Ability)
                Ability3();
        }
        if (currentBullets < maxBullets / 6)
        {
            lowAmmo.SetActive(true);
        } else
        {
            lowAmmo.SetActive(false);
        }

    }
    void Shoot()
    {
        muzzleFlash.Play();
        currentBullets--;
        RaycastHit hit;
        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            Enemy enemy = hit.transform.GetComponent<Enemy>();
            chestDestroy chestdestroy = hit.transform.GetComponent<chestDestroy>();

            if (enemy != null)
            {
                enemy.TakeDamage(damage);
            }
                if(hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * impactForce);
            }
            if (chestdestroy != null)
            {
                chestdestroy.TakeDamage(damage);
            }
            if (hit.rigidbody != null)
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
            Debug.Log(hit.transform.name);
            Enemy enemy = hit.transform.GetComponent<Enemy>();
            if (enemy != null)
            {
                player1.playerEnergy -= requiredEnergy2Ability;
                ability2Timer = ability2TimerReset;
                enemy.TakeDamage(abilityQdamage);
                Instantiate(ability2, enemy.transform.position, enemy.transform.rotation);
            }
            if (hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * impactForce);
            }
        }
    }
    void Ability3()
    {
        player1.playerHealth += 30;
        ability3[0].Play();
        ability3[1].Play();
        ability3[2].Play();
        ability3Timer = ability3TimerReset;
        player1.playerEnergy -= requiredEnergy3Ability;



    }
    void AbilityResetUi()
    {
        abilityQImage.fillAmount = abilityQTimer / 10f;
        ability2Image.fillAmount = ability2Timer / 10f;
        ability3Image.fillAmount = ability3Timer / 10f;


    }
    public void weaponReaload()
    {
        currentBullets = maxBullets;
    }
}

