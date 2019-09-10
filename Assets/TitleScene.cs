using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleScene : MonoBehaviour {
	public Text blinkText;
	const float FlipTime = 0.7f;//切り替えまでの時間
	private float TimeCount=0.0f;//タイムカウント
	// Use this for initialization
	void Start () {
		
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Submit")) {
			SceneManager.LoadScene ("Main");
		}
		TimeCount += Time.deltaTime;
		if (TimeCount >= FlipTime) {
			blinkText.enabled = !blinkText.enabled;
			TimeCount = 0.0f;
		}


	}
}