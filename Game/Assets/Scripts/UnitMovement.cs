using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class UnitMovement : MonoBehaviour
{

    [SerializeField] private GameObject target;
    [SerializeField] private float range;
    private NavMeshAgent agent;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = target.transform.position;
        if(animator != null&&Vector3.Distance(gameObject.transform.position, target.transform.position)>range)
        {
            animator.Play("Run");
        }

        if (animator != null && Vector3.Distance(gameObject.transform.position, target.transform.position) <= range)
        {
            animator.Play("Claw Attack");
        }

        if (animator == null && Vector3.Distance(gameObject.transform.position, target.transform.position) <= 1)
        {
            GameObject.Destroy(gameObject);
        }

    }
}
