using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Cat : MonoBehaviour
{
    public NavMeshAgent agent; //choose a gameobject to be agent

    public Transform target; //choose a gameobject to be target
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>(); //get nav mesh agent component
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.position); //follow the target
    }
}
