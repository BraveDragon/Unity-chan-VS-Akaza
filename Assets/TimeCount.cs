using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeCount : MonoBehaviour {
    public Text time;//表示する文字
    const float Second = 1.0f;//１秒
    private float timecount = 0.0f;
    float LeftTime;//残り時間

    //勝者の判定(HPが０になった時)
    void Judge_HP(){
        if (CharacterManager.player1.HP == 0)
        {
            SceneManager.LoadScene("Win_2P");
        }

        if (CharacterManager.player2.HP == 0)
        {
            SceneManager.LoadScene("Win_1P");
        }
    }

    //勝者の判定(時間切れ時)
    void Judge(){
        if (CharacterManager.player1.Score > CharacterManager.player2.Score){
            SceneManager.LoadScene("Win_1P");
        }
        if (CharacterManager.player1.Score < CharacterManager.player2.Score)
        {
            SceneManager.LoadScene("Win_2P");
        }
        if (CharacterManager.player1.Score == CharacterManager.player2.Score)
        {
            if (CharacterManager.player1.HP > CharacterManager.player2.HP)
            {
                SceneManager.LoadScene("Win_1P");
            }
            if (CharacterManager.player1.HP < CharacterManager.player2.HP)
            {
                SceneManager.LoadScene("Win_2P");
            }
            else{ SceneManager.LoadScene("Draw"); }
        }
    }
	// Use this for initialization
	void Start () {
        LeftTime = Constants.TimeLimit;
	}
	
	// Update is called once per frame
	void Update () {
        time.text = LeftTime.ToString();
        timecount += Time.deltaTime;
        //このコメントの中はテスト用。終わったら消すこと。
        //if (Input.GetKeyDown(KeyCode.Q) == true){SceneManager.LoadScene("Win_1P"); }
        //if (Input.GetKeyDown(KeyCode.E) == true){SceneManager.LoadScene("Win_2P"); }
        if (Input.GetKeyDown(KeyCode.T) == true){ CharacterManager.player1.Damage(10); }
        if (Input.GetKeyDown(KeyCode.Y) == true){ CharacterManager.player2.Damage(10); }
        //
        if (timecount >= Second)
        {
            LeftTime -= 1.0f;
            timecount = 0.0f;
        }

        if (LeftTime == 0){
            Judge();
        }

		Judge_HP ();

    }
}
