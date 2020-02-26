using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class but : MonoBehaviour {

	// Use this for initialization


	public void play(){
		SceneManager.LoadScene ("SampleScene");
	}
	
	// Update is called once per frame
	public void tutorial(){
		//SceneManager.LoadScene ("start menu 1");
	}

	public void back(){
		//SceneManager.LoadScene ("start menu");
	}

	public void next() {
		//SceneManager.LoadScene ("Tutorial_Star");
	}

	public void exit(){
		UnityEditor.EditorApplication.isPlaying = false;
		Application.Quit();
	}




}
