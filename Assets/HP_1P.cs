using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP_1P : MonoBehaviour {
    public Slider HPGauge;
    public Text Score;
    
	// Use this for initialization
	void Start () {
        
        HPGauge.maxValue = Constants.MaxHP;
    }
	
	// Update is called once per frame
	void Update () {
        HPGauge.value = CharacterManager.player1.HP;
        Score.text = "SCORE : " + string.Format("{0:00000}", CharacterManager.player1.Score.ToString());
    }
}
