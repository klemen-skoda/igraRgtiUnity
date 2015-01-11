﻿using UnityEngine;
using System.Collections;

public class gameManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		pauseGame ();
	}

	// Update is called once per frame
	void Update () {
		if ( Input.GetButtonDown( "Cancel" )) {
			pauseGame();
		}
	}

	private void enablePanel( string name ){

		GameObject giuCanvas = GameObject.Find ("GuiCanvas");
		
		foreach (Transform child in giuCanvas.transform) {
			if( child.name == name ) child.gameObject.SetActive( true );
			else child.gameObject.SetActive( false );
		}
	}

	private void selectCamera( string name){

		foreach (Camera camera in Camera.allCameras) {
			if( camera.name == name) camera.enabled= true;
			else camera.enabled= false;
		}
	}

	public void restartGame(){
		Application.LoadLevel (0);
	}

	public void startGame(){

		enablePanel ("hud");
		selectCamera ("MainCamera");
		Screen.showCursor = false;
		Time.timeScale = 1;
		enableControll ();
	}

	public void pauseGame(){

		Time.timeScale = 0;
		//selectCamera ("MenuCamera");
		enablePanel ("mainMenu");
		Screen.showCursor = true;
		disableControl ();
	}

	public void gameOver(){

		Time.timeScale = 0;
		enablePanel ("gameOver");
		Screen.showCursor = true;
		disableControl ();

	}

	public void exitGame(){
		Application.Quit ();
	}

	void disableControl(){
		GameObject player = GameObject.Find ("Player");
		player.GetComponent<CharacterController> ().enabled = false;
		player.GetComponent<MouseLook> ().sensitivityX = 0;
		player.GetComponent<MouseLook> ().sensitivityY = 0;
	}

	void enableControll(){
		GameObject player = GameObject.Find ("Player");
		player.GetComponent<CharacterController> ().enabled = true;
		player.GetComponent<MouseLook> ().sensitivityX = 3;
		player.GetComponent<MouseLook> ().sensitivityY = 3;
	}

}
