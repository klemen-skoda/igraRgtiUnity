﻿using UnityEngine;
using System.Collections;

public class collisionManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter(Collider other) {
		Physics.IgnoreLayerCollision( 8, 9, true );
	}
	
}
