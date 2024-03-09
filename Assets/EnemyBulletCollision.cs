using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletCollision : MonoBehaviour
{
    // Start is called before the first frame update
    PlayerScript player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        //Sphereが衝突したオブジェクトがPlaneだった場合
        if(collision.gameObject.name == "ForestField"){
            Destroy (gameObject);
        } 
        else if (collision.gameObject.tag == "Player") {
            //あたった相手(Target)からスクリプトの情報を手に入れる
            player = collision.gameObject.GetComponent<PlayerScript>();
            //target(スクリプト)のDamage()関数を呼ぶ
            player.Damage ();

            Destroy (gameObject);
        }
    }
}
