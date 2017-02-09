﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartQuit : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.R)) {
			SceneManager.LoadScene (0);
		}

		if (Input.GetKeyDown (KeyCode.Escape) || Input.GetKeyDown (KeyCode.Q)) {
			Application.Quit();
		}
	}
}
