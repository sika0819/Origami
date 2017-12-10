using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour {
    AudioSource soundPlayer;
	// Use this for initialization
	void Start () {
        soundPlayer = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void PlaySound(AudioClip audio) {
        soundPlayer.clip = audio;
        soundPlayer.Play();
    }
}
