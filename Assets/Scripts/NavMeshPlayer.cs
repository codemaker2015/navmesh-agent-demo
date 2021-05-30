using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshPlayer : MonoBehaviour
{

    GameObject destination;
	NavMeshAgent navMeshAgent;
 
	// Start is called before the first frame update
	void Start () {
		destination = GameObject.Find ("Destination");
		navMeshAgent = GetComponent<NavMeshAgent> ();
		navMeshAgent.SetDestination(destination.transform.position);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}