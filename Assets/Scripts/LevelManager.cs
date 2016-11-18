
print("Quit Level");﻿using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void loadLevel(string name){
		Debug.Log("Level load requested for " + name);
		Application.LoadLevel(name);
	}

	public void quitLevel(){
		Debug.Log("Quit Level requested");
		print("Quit Level");
		Application.Quit();
	}
}
