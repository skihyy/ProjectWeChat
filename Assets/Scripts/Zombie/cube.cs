﻿using UnityEngine;
using System.Collections;

public class cube : MonoBehaviour {
	public Vector3 des;
	NavMeshAgent nav;

	// Use this for initialization
	void Awake () {
		nav = GetComponent<NavMeshAgent> ();
		des = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		nav.SetDestination (des);
	}


	public void setSpeed(int state){
		if (state == 0) {
			nav.speed = 0.5f;
		} else if (state == 1) {
			nav.speed = 3.0f;
		} else if (state == 2) {
			nav.speed = 0.0f;
		}

	}
}
