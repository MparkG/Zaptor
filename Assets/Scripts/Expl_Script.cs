﻿using UnityEngine;
using System.Collections;

public class Expl_Script : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		if(gameObject.particleSystem.isPlaying == false)
			Destroy (gameObject);
	}
}
