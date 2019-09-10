using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour {
    const byte Monsters=2;//一回ごとに出現するモンスターの数
    const float SpawnTime = 2.0f;//出現の間隔（秒）
    private float TimeCount = 0.0f;//時間カウント
    public GameObject MonsterA;
    public GameObject MonsterB;
    Vector3 SpawnPointA;
    Quaternion SpawnRotationA;
    Vector3 SpawnPointB;
    Quaternion SpawnRotationB;
    // Use this for initialization
    void Start () {
        SpawnPointA = new Vector3();
        SpawnPointB = new Vector3();
    }
	
	// Update is called once per frame
	void Update () {
        TimeCount += Time.deltaTime;
        if (TimeCount >= SpawnTime){
            for (byte i = 0; i < Monsters; i++)
              {
                SpawnPointA = new Vector3(Random.Range(-500, 1000), 
                                          Random.Range(2, 3),
                                          Random.Range(-500, 1000));
                SpawnRotationA = Quaternion.Euler(0, Random.Range(0, 360), 0);
                SpawnPointB = new Vector3(Random.Range(-500, 1000),
                                          Random.Range(2, 3),
                                          Random.Range(-500, 1000));
                SpawnRotationB = Quaternion.Euler(0, Random.Range(0, 360), 0);
                Instantiate(MonsterA, SpawnPointA, SpawnRotationA);
                Instantiate(MonsterB, SpawnPointB, SpawnRotationB);

            }





        }
	}
}
