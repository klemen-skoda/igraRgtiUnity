using UnityEngine;
using System.Collections;

public class mover : MonoBehaviour {

	public float speed;

	void Update () {
		rigidbody.velocity = transform.forward * speed;
	}

}
