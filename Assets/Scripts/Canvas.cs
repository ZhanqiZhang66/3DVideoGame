using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Canvas : MonoBehaviour {

	// Use this for initialization
	public GameObject pause_panel;
	public GameObject game_panel;
	public AudioSource bgm;
	
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
	
	public void Restart(){
		Time.timeScale = 1;
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		//pause_panel.SetActive (false);
		//game_panel.SetActive (true);
	}
	
	public void MainMenu(){

		SceneManager.LoadScene ("start menu");
	}
	
	public void Pause(){
		
		Time.timeScale = 0;
		bgm.Pause();
		pause_panel.SetActive (true);
		game_panel.SetActive (false);
	}

	public void Unpause(){
		Time.timeScale = 1;
		bgm.Play();
		pause_panel.SetActive (false);
		game_panel.SetActive (true);
	}
}