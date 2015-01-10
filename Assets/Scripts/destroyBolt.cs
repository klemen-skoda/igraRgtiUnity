using UnityEngine;
using System.Collections;

public class destroyBolt : MonoBehaviour {
	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Boundary" || other.tag == "Player")
		{
			return;
		}
		Destroy(gameObject);
	}
}
