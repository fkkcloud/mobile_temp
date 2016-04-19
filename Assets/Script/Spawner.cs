﻿using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public GameObject[] attackerPrefabArray;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		foreach (GameObject attacker in attackerPrefabArray) {
			if (IsTimeToSpawn (attacker)) {
				Spawn (attacker);
			}
		}
	}

	void Spawn(GameObject attackerGameObj){
		GameObject myAttacker = Instantiate (attackerGameObj) as GameObject;
		myAttacker.transform.parent = transform;
		myAttacker.transform.position = transform.position;
	}

	bool IsTimeToSpawn(GameObject attackerGameObj){
		Attacker attacker = attackerGameObj.GetComponent<Attacker> ();

		float meanSpawnDelay = attacker.seenEverySeconds;
		float spawnsPerSecond = 1 / meanSpawnDelay;

		if (Time.deltaTime > meanSpawnDelay) {
			Debug.LogError ("Spawn rate is capped by framerate");
		}

		float threshold = spawnsPerSecond * Time.deltaTime;

		if (Random.value < threshold) {
			return true;
		} else {
			return false;
		}

		return false;
	}
}
