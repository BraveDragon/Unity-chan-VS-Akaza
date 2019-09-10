using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinningText2P : MonoBehaviour {
    public Text text;
	
	// Update is called once per frame
	void Update () {
        text.text = ("SCORE : "+ CharacterManager.player2.Score.ToString());

    }
}
