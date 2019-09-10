using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Voice : MonoBehaviour {
	public AudioSource voice;
	public AudioClip Voice1;
	public AudioClip Voice2;
    private float timer;

    // Use this for initialization
    void Start () {
        voice.clip = Voice1;
        voice.Play();
        Invoke("Voice2_Play", Voice1.length);
    }

 

    void Voice2_Play(){
        voice.clip = Voice2;
        voice.Play();
    }

}
