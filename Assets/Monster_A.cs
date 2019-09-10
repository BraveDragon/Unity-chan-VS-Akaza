using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Monster_A : MonoBehaviour {
    public static Monster monster_A = new Monster(10.0f);
    public GameObject explosion;
    // Use this for initialization
    void Start () {
        Destroy(this.gameObject, 4.0f);
    }
	
	// Update is called once per frame
	void Update () {
        transform.position += transform.forward * Time.deltaTime * monster_A.Speed;
	}
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet1")
        {
            CharacterManager.player1.Score += Constants.GainScore_MonsterA;
           
            Destroy(this.gameObject);
            Instantiate(explosion, transform.position, transform.rotation);
        }

        if (collision.gameObject.tag == "Bullet2")
        {
            CharacterManager.player2.Score += Constants.GainScore_MonsterB;
            
            Destroy(this.gameObject);
            Instantiate(explosion, transform.position, transform.rotation);
        }
    }
}
