using UnityEngine;
using System.Collections;

public class gameManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Screen.showCursor = false;
	}
	
	// Update is called once per frame
	void Update () {
		if ( Input.GetButtonDown( "Cancel" )) {
			Application.LoadLevel(0);
		}
	}
}
