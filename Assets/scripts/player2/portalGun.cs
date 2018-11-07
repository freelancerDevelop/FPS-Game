using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portalGun : MonoBehaviour {


    public GameObject particleSystem;
    public Camera fpsCam;
    public float range = 100f;
    public GameObject Portal1;
    public GameObject Portal2;
    public Transform player;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if (Input.GetKey(KeyCode.Mouse0))
        {
            //particleSystem.SetActive(true);
        } else
        {
            particleSystem.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            portal1();
        }

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            portal2();
        }
    }
    void portal1()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Portal1.transform.position = hit.point;
            Portal1.transform.rotation = Quaternion.LookRotation(hit.normal);
            Debug.Log(hit.transform.name);
            player.transform.rotation = Quaternion.LookRotation(hit.normal);
            //Instantiate(Portal1, hit.point, Quaternion.LookRotation(hit.normal));

        }
    }

    void portal2()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Portal2.transform.position = hit.point;
            Portal2.transform.rotation = Quaternion.LookRotation(hit.normal);
            Debug.Log(hit.transform.name);
            player.transform.rotation = Quaternion.LookRotation(hit.normal);

        }
    }
}
