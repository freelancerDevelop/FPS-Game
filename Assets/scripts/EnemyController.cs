using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour {

    public float lookRadius = 10f;
    public Transform target;
    NavMeshAgent agent;
    public Animator anim;
    public float controlSpeed;
	// Use this for initialization
	void Start () {
        agent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
        anim.SetFloat("speed", controlSpeed);
        controlSpeed = 0f;
        agent.enabled = true;

        float distance = Vector3.Distance(target.position, transform.position);
        if(distance <= lookRadius)
        {
            controlSpeed = 1f;

            agent.SetDestination(target.position);
            if(distance <= agent.stoppingDistance)
            {
                FaceTarget();
                controlSpeed = 2f;
                agent.enabled = false;
            }
        }

    }
    void FaceTarget()
    {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position, lookRadius);
    }
}
