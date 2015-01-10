using UnityEngine;
using System.Collections;

public class enemyMover : MonoBehaviour
{
	Transform player;
	//PlayerHealth playerHealth;
	//EnemyHealth enemyHealth;
	NavMeshAgent nav;
	
	
	void Awake ()
	{
		player = GameObject.FindGameObjectWithTag ("Player").transform;
		//playerHealth = player.GetComponent <PlayerHealth> ();
		//enemyHealth = GetComponent <EnemyHealth> ();
		nav = GetComponent <NavMeshAgent> ();
	}
	
	
	void Update ()
	{
		//if(enemyHealth.currentHealth > 0 && playerHealth.currentHealth > 0)
		//{
		nav.SetDestination (player.position);
		if (nav.hasPath) {
			animation.CrossFade("Walk");
		}else{
			animation.CrossFade("Idle");
		}
		//}
		//else
		//{
		//    nav.enabled = false;
		//}
	}
}
