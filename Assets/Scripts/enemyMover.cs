using UnityEngine;
using System.Collections;

public class enemyMover : MonoBehaviour
{
	Transform player;
	playerHP playerHealth;
	enemyHP enemyHealth;
	NavMeshAgent nav;
	
	
	void Awake ()
	{
		player = GameObject.FindGameObjectWithTag ("Player").transform;
		playerHealth = player.GetComponent <playerHP> ();
		enemyHealth = GetComponent <enemyHP> ();
		nav = GetComponent <NavMeshAgent> ();
	}
	
	
	void Update ()
	{
		if(enemyHealth.currentHealth > 0 && playerHealth.currentHealth > 0)
		{
			nav.SetDestination (player.position);
			if (nav.hasPath) {
				animation.CrossFade("Walk");
			}else{
				animation.CrossFade("Idle");
			}
		}
		else
		{
		    nav.enabled = false;
		}
	}
}
