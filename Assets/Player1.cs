using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour {
	
    CharacterController Controler;
    Animator animation;
    private Vector3 direction = Vector3.zero;
    
    // Use this for initialization
    void Start () {
        Controler = GetComponent<CharacterController>();
        animation = GetComponentInChildren<Animator>();
        
    }

    // Update is called once per frame
    public GameObject Bullet;
    public GameObject WeaponPoint;
    private float Rotation;
    void Update () {
        //  CharacterManager.player1.Update(Controler, Bullet, WeaponPoint, gameObject, animation);
       if (CharacterManager.player1.HP == 0){ animation.SetBool("DeadFlag", true); }
       if (CharacterManager.player1.HP > 0)
        {
           
            if (Controler.isGrounded)
            {
                Rotation += Input.GetAxis("Horizontal_1P") * Constants.Rotation * Time.deltaTime;
                direction = new Vector3(Input.GetAxis("Horizontal_1P"), 0, Input.GetAxis("Vertical_1P"));
                direction = transform.TransformDirection(direction);
                direction *= Constants.Speed;

                if (Input.GetButton("Jump_1P"))
                {
                    direction.y = Constants.Jump;
                    animation.SetTrigger("JumpTrigger");
                }

            }
            

            if (Input.GetButtonDown("Fire1_1P"))
            {
               
            
                    animation.SetTrigger("AttackFlag");
                    Vector3 BulletPosition = WeaponPoint.transform.position;
                    BulletPosition += (transform.rotation * Vector3.forward);
                    BulletPosition.y = 1.0f;
                    Instantiate(Bullet, BulletPosition, transform.rotation);
           
                
            }
            
           
        }

        


        direction.y -= Constants.Gravity * Time.deltaTime;
        transform.rotation = Quaternion.Euler(0, Rotation, 0);
        Controler.Move(direction * Time.deltaTime);
        animation.SetFloat("Move", Controler.velocity.magnitude);
        
     
    }

    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet2") {
            CharacterManager.player1.Damage(Constants.BulletDamage);
        }
        if (collision.gameObject.tag == "MonsterA") { CharacterManager.player1.Damage(Constants.Damage_MonsterA); }
        if (collision.gameObject.tag == "MonsterB") { CharacterManager.player1.Damage(Constants.Damage_MonsterB); }
    }
   
}
