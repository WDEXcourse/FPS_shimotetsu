using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    public GameObject bulletPrefab;

    void Start () {

    }

    void Update () {
        //もし、マウスボタンがおされたら、Shot()関数にとぶ
        if (Input.GetMouseButtonDown (0)) {
            Shot ();
        }

    }

    //Shot()関数をつくる
    void Shot(){
        //GameObject型の「bullet」をつくる。クローンされた弾の実体を保存する変数
        GameObject bullet;
        //「bullet」に「bulletPrefab」のインスタンス（クローン）をセットする
        bullet = GameObject.Instantiate (bulletPrefab);
        //「bullet」の位置座標に今の「Muzzle」の位置座標をセットする
        bullet.transform.position = transform.position;
        //「bullet」のRigidbody(重力)に、今の「Muzzle」のz軸方向に1000をかけたパワーを加える
        bullet.GetComponent<Rigidbody> ().AddForce (transform.forward * 100);
    }
}
