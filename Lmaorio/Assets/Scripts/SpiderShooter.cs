﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderShooter : MonoBehaviour {

	[SerializeField]
	private GameObject bullet;
	public Play player;
	// Use this for initialization
	void Start () {
		StartCoroutine (Attack ());
		player = GameObject.FindGameObjectWithTag("Player").GetComponent<Play>();
	}

	// Update is called once per frame
	void Update () {

	}

	IEnumerator Attack(){
		yield return new WaitForSeconds (Random.Range (2, 7));
		Instantiate (bullet, transform.position, Quaternion.identity);
		StartCoroutine (Attack ());
	}

	void OnTriggerEnter2D(Collider2D target){
		if (target.tag == "Player") {
			player.Damage(2);
		}
	}
}
