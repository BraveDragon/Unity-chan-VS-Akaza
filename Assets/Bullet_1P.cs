using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_1P : MonoBehaviour {
    public GameObject explosion;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += transform.forward * Time.deltaTime * Constants.BulletSpeed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "MonsterA")
        {
            
            
           
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(this.gameObject);




        }
        if (collision.gameObject.name == "MonsterB")
        {
           
            
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(this.gameObject);
            
            
           

        }
    }
}
