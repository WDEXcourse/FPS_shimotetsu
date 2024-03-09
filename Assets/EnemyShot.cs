using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemyBulletPrefab;
    
    private float timeTrigger = 1.0f;

    void Update() {
        if(Time.time > timeTrigger) {
            // Do anything
            Shot();
            timeTrigger = Time.time + timeTrigger;
        }
    }

    void Shot(){
        //GameObject型の「bullet」をつくる。クローンされた弾の実体を保存する変数
        GameObject enemyBullet;
        //「bullet」に「bulletPrefab」のインスタンス（クローン）をセットする
        enemyBullet = GameObject.Instantiate (enemyBulletPrefab);
        //「bullet」の位置座標に今の「Muzzle」の位置座標をセットする
        enemyBullet.transform.position = transform.position;
        //「bullet」のRigidbody(重力)に、今の「Muzzle」のz軸方向に1000をかけたパワーを加える
        enemyBullet.GetComponent<Rigidbody> ().AddForce (transform.forward * 100);
    }
}
