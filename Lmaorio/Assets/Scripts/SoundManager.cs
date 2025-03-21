using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {
	public AudioClip coins, swords, destroy , key ,soi , jup , kick , bump;

	public AudioSource adisrc;
	// Use this for initialization
	void Start () {
		coins = Resources.Load<AudioClip>("Gamecoin");
		swords = Resources.Load<AudioClip>("Sword");
		destroy = Resources.Load<AudioClip>("RockCrash");
		key = Resources.Load<AudioClip> ("coin");
		soi = Resources.Load<AudioClip> ("fireball");
		jup = Resources.Load<AudioClip> ("jup");
		kick = Resources.Load<AudioClip> ("kick");
		bump = Resources.Load<AudioClip> ("bump");
		adisrc = GetComponent<AudioSource>();

	}

	public void Playsound(string clip)
	{
		switch (clip)
		{
		case "coins":
			adisrc.clip = coins;
			adisrc.PlayOneShot(coins, 0.6f);
			break;

		case "destroy":
			adisrc.clip = destroy;
			adisrc.PlayOneShot(destroy, 1f);
			break;

		case "sword":
			adisrc.clip = swords;
			adisrc.PlayOneShot(swords, 1f);
			break;
		case "key":
			adisrc.clip = key;
			adisrc.PlayOneShot(key, 0.6f);
			break;
		case "soi":
			adisrc.clip = soi;
			adisrc.PlayOneShot(soi, 0.6f);
			break;
		case "jup":
			adisrc.clip = jup;
			adisrc.PlayOneShot(jup, 1f);
			break;
		case "kick":
			adisrc.clip = kick;
			adisrc.PlayOneShot(kick, 0.6f);
			break;
		case "bump":
			adisrc.clip = bump;
			adisrc.PlayOneShot(bump, 0.6f);
			break;

		}
	}
}
