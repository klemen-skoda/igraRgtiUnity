using UnityEngine;
using UnityEngine.UI;

public class enemyHP : MonoBehaviour
{
	public int startingHealth = 100;
	public int currentHealth;
	public float sinkSpeed = 2.5f;
	public int scoreValue = 10;
	public AudioClip deathClip;
	public AudioClip hit;
	
	
	CapsuleCollider capsuleCollider;
	bool isDead;
	bool isSinking;
	
	
	void Awake ()
	{
		capsuleCollider = GetComponent <CapsuleCollider> ();
		currentHealth = startingHealth;
	}
	
	
	void Update ()
	{
		if(isSinking)
		{
			transform.Translate (-Vector3.up * sinkSpeed * Time.deltaTime);
		}
	}
	
	
	public void TakeDamage (int amount, Vector3 hitPoint)
	{
		if(isDead)
			return;
		
		audio.PlayOneShot(hit);
		currentHealth -= amount;

		if(currentHealth <= 0)
		{
			Death ();
		}
	}
	
	
	void Death ()
	{
		isDead = true;
		StartSinking ();
		capsuleCollider.isTrigger = true;
		animation.CrossFade ("Death");
		audio.PlayOneShot(deathClip);
	}
	
	
	public void StartSinking ()
	{
		GetComponent <NavMeshAgent> ().enabled = false;
		GetComponent <Rigidbody> ().isKinematic = true;
		isSinking = true;
		changeScore.score += scoreValue;
		Destroy (gameObject, 2f);
	}
}
