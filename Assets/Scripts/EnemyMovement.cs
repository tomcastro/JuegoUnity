using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour 
{
	Transform player;
	NavMeshAgent nav;

	void Awake()
	{
		player = GameObject.FindGameObjectWithTag ("Player").transform;
		nav = GetComponent <NavMeshAgent> ();
		Debug.Log (nav.acceleration);
	}

	void Update()
	{
		nav.SetDestination (player.position);
	}
}
