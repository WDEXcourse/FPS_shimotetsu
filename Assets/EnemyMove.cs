using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public GameObject Player;
    public Vector3 nowEnemyPosition;
    private int enemyHP;
    // Start is called before the first frame update
    void Start()
    {
        enemyHP = 50;
        nowEnemyPosition = this.transform.position;
        Player = GameObject.Find("Player");

    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.y < 0.6f){
            this.transform.position = new Vector3(this.transform.position.x,0.6f,this.transform.position.z);
        }
        nowEnemyPosition = this.transform.position;

        this.transform.LookAt(Player.transform);

        this.transform.Translate (0.0f,0.0f,0.02f);
    }
    public void Damage(){
        enemyHP -= 10;
        if(enemyHP <= 0){
            float timer = 0.3f;
            //自分自身のゲームオブジェクト（Target）を0.3待ってから削除する
            Destroy (gameObject,timer);
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        //Sphereが衝突したオブジェクトがPlaneだった場合
        if(collision.gameObject.name == "ForestField"){
            this.transform.position = nowEnemyPosition;
        }
    }
}
