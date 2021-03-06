﻿using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public GameObject L1Enemy;
	public GameObject L2Enemy;
	public GameObject L3Enemy;
	public GameObject L4Enemy;

	private float spawnInterval;
	private float timeStamp;

	// Use this for initialization
	void Start () 
	{
		spawnInterval = Random.Range (4f, 12f);
		timeStamp = Time.time;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Time.time - timeStamp >= spawnInterval)
		{
			try{	// if player gets destroyed, nothing executes.
				float score = PlayerController.score;
				if(score <= 150)
					Instantiate(L1Enemy, transform.position, new Quaternion());
				else if(score <= 450)
				{
					if(Random.Range(0f, 1f) < 0.6f)
						Instantiate(L1Enemy, transform.position, new Quaternion());
					else
						Instantiate(L2Enemy, transform.position, new Quaternion());
				}
				else if(score <= 800)
				{
					float rnd = Random.Range (0f, 1f);
					if(rnd < 0.3f)
						Instantiate(L1Enemy, transform.position, new Quaternion());
					else if(rnd >= 0.3f && rnd < 0.8f)
						Instantiate(L2Enemy, transform.position, new Quaternion());
					else
						Instantiate(L3Enemy, transform.position, new Quaternion());
				}
				else
				{
					float rnd = Random.Range (0f, 1f);
					if(rnd < 0.2f)
						Instantiate(L1Enemy, transform.position, new Quaternion());
					else if(rnd >= 0.2f && rnd < 0.55f)
						Instantiate(L2Enemy, transform.position, new Quaternion());
					else if(rnd >= 0.55f && rnd < 0.75f)
						Instantiate(L3Enemy, transform.position, new Quaternion());
					else
						Instantiate(L4Enemy, transform.position, new Quaternion());
				}
				
				Start ();	// randomize the spawn interval after every spawn
			} catch{
				print("Error Spawning");
			}

		}
	}
}
