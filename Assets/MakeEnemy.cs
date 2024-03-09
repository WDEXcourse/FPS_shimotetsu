using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeEnemy : MonoBehaviour
{
    public GameObject enemyPrefab;
    // Start is called before the first frame update
    void Start()
    {
        GameObject enemy;
        //「bullet」に「bulletPrefab」のインスタンス（クローン）をセットする
        //「bullet」の位置座標に今の「Muzzle」の位置座標をセットする
        for(float z = -10.0f;z < 10.0f;z+=5.0f){
            for(float x = -10.0f;x < 10.0f;x+=5.0f){
                enemy = GameObject.Instantiate (enemyPrefab);
                enemy.transform.position = new Vector3(x,1.0f,z);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
