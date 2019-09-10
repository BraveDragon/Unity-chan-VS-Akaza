using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterManager : MonoBehaviour {

    public static CharacterManager charactermanager;
    public GameObject player1_object;
    public GameObject player2_object;
    public static Player player1 = new Player();
    public static Player player2 = new Player();
    // Use this for initialization
    void Start () {
        if (charactermanager == null){
            charactermanager = this;
        }
        DontDestroyOnLoad(this);
	}
	
	// Update is called once per frame
	void Update () {
         if(SceneManager.GetActiveScene().name == "Start"){
               player1.Initialize();
               player2.Initialize();
         }
		
	}
}
