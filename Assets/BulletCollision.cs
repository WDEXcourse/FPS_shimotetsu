using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollision : MonoBehaviour
{
    EnemyMove enemy;
    // Start is called before the first frame update
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
        else if (collision.gameObject.tag == "Enemy") {
            //あたった相手(Target)からスクリプトの情報を手に入れる
            enemy = collision.gameObject.GetComponent<EnemyMove>();
            //target(スクリプト)のDamage()関数を呼ぶ
            enemy.Damage ();

            Destroy (gameObject);
        }
    }
}
