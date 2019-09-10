using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//定数やクラス類などをまとめたスクリプト
public class Utilities : MonoBehaviour {
}
public struct Constants{
	public const byte TimeLimit=60;//制限時間
	public const float MaxHP=500;//初期のＨＰ（最大値）
    public const byte BulletDamage = 50;//弾がプレイヤーに当たった時のダメージ
    public const float Speed = 15.0f;//移動速度
    public const float Jump = 8.0f;//ジャンプ速度
    public const float Gravity = 20.0f;//重力
    public const float Rotation = 90.0f;//曲がる時の角度
    public const float BulletSpeed = 45f;//弾速
    public const ushort GainScore_MonsterA = 100;//モンスターAを倒した時の得点
    public const ushort GainScore_MonsterB = 200;//モンスターBを倒した時の得点
    public const ushort Damage_MonsterA = 20;//モンスターAにぶつかった時受けるダメージ
    public const ushort Damage_MonsterB = 10;//モンスターBにぶつかった時受けるダメージ


}




//プレイヤーのクラス
public class Player
{
    public float HP { get; private set; }//HP
    public uint Score { get; set; }//得点
    public GameObject PlayerObject;
    //初期化は行っておく
    public Player()
    {
        HP = Constants.MaxHP;
        Score = 0;
        
      
    }
    //ダメージの処理
    public void Damage(ushort damage)
    {
        if (HP >= damage) { HP -= damage; }
        else { HP = 0; }
    }
    //HPを回復
    public void Recover(ushort recoverHP)
    {
        if (Constants.MaxHP >= HP + recoverHP) { HP += recoverHP; }
        else { HP = Constants.MaxHP; }
    }
    //スコアとHPを初期化
    public void Initialize(){
        HP = Constants.MaxHP;
        Score = 0;
    }

   ///* public void Update(CharacterController Controler,
   //                    GameObject Bullet,
   //                    GameObject WeaponPoint,
   //                    GameObject PlayerObject,
   //                    Animator animation,
   //                    float Rotation = 0.0f)
   // {


   //     if (this.HP > 0)
   //     {

   //         if (Controler.isGrounded)
   //         {
   //             Rotation += Input.GetAxis(("Horizontal" + PlayerType)) * Constants.Rotation * Time.deltaTime;
   //             PlayerObject.transform.position = new Vector3(Input.GetAxis(("Horizontal" + PlayerType)), 0, Input.GetAxis(("Vertical" + PlayerType)));
   //             PlayerObject.transform.position = PlayerObject.transform.TransformDirection(PlayerObject.transform.position);
   //             PlayerObject.transform.position *= Constants.Speed;

   //             if (Input.GetButton(("Jump" + PlayerType)))
   //             {
   //                 PlayerObject.transform.position.Set(0,Constants.Jump,0);
   //             }

   //         }

   //         /*	if (Input.GetButtonDown("Fire1_1P"))
   //             {
   //                 AttackFlag = true;
   //                 if (null != WeaponPoint)
   //                 {
   //                     Vector3 BulletPosition = WeaponPoint.transform.position;
   //                     BulletPosition += (transform.rotation * Vector3.forward);
   //                     BulletPosition.y = 1.0f;
   //                     Instantiate(Bullet, BulletPosition, transform.rotation);
   //                 }

   //             }
   //             else{ AttackFlag = false; } 

   //         } */




   //         PlayerObject.transform.position.Set(0, -(Constants.Gravity * Time.deltaTime), 0);
   //         PlayerObject.transform.rotation = Quaternion.Euler(0, Rotation, 0);
   //         Controler.Move(PlayerObject.transform.position * Time.deltaTime);
   //         animation.SetFloat("Move", Controler.velocity.magnitude);
   //         //animation.SetBool("Attack", AttackFlag);




   //     }
   // }
}
//モンスターのクラス
public class Monster
    {
    
      
 
        
        //スピード
        public float Speed { get; private set; }
        //手に入る得点
        

        public Monster(float speed)
        { 
            
            Speed = speed;
         
        }

    }
