﻿using UnityEngine;
using System.Collections;

public class crosshair : MonoBehaviour {
	
	void OnGUI(){
		GUI.Box(new Rect(Screen.width/2,Screen.height/2, 10, 10), "Textures/crosshair transparent");
	}
}
