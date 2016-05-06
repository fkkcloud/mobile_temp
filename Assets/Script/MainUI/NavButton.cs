﻿using UnityEngine;
using System.Collections;

public class NavButton : MonoBehaviour {

	private GameObject[] lists;

	private int scrollUICount = 3;

	// Use this for initialization
	void Start () {
		lists = new GameObject[scrollUICount];

		lists [0] = GameObject.FindGameObjectWithTag ("Scroll01_Belt");
		lists [1] = GameObject.FindGameObjectWithTag ("Scroll02_Upper");
		lists [2] = GameObject.FindGameObjectWithTag ("Scroll03_Lower");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ActiveScrollUIWithID(int id){
		for (int i = 0; i < scrollUICount; i++) {
			lists [i].SetActive (false);
		}

		lists [id].SetActive (true);
	}
}