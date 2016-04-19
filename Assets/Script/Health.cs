﻿using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	public float HitPoint = 100f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void DealDamage(float damage){
		HitPoint -= damage;
		if (HitPoint <= 0) {
			// Optionally do die animation
			// Important thing to know is that if I have die animation,
			// make sure to call the DestroyObject function in the Animator when the animation end! just like the SetSpeed()!
			DestroyObject();
		}
	}

	void DestroyObject(){
		Destroy (gameObject);
	}
}
