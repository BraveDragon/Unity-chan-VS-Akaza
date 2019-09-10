using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win_1P : MonoBehaviour {
    Animator animation;
	// Use this for initialization
	void Start () {
        animation = GetComponentInChildren<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        //animation.SetBool("Win", true);
	}
}
