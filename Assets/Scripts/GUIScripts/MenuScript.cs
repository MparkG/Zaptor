﻿using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {

	public AudioClip beep;

	void Start()
	{
		transform.GetChild(0).gameObject.SetActive(false);
	}

	void OnMouseEnter()
	{
		// change color on mouse over
		guiText.color = Color.green;
		transform.GetChild(0).gameObject.SetActive(true);
		audio.Play();
	}

	void OnMouseExit()
	{
		// change color back to white
		guiText.color = Color.white;
		transform.GetChild(0).gameObject.SetActive(false);
	}

	void OnMouseDown()
	{
		if(this.name == "Play"){
			Destroy(GameObject.Find("MenuMusic"));
			Application.LoadLevel("game");
		}
		if(this.name == "Quit")
			Application.Quit();
		if(this.name == "Instructions")
			Application.LoadLevel("instructions");
		if(this.name == "Credits")
			Application.LoadLevel("credits");
		if(this.name == "Back")
			Application.LoadLevel("menu");
	}
}
