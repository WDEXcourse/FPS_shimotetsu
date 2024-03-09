using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerScript : MonoBehaviour
{
    const float mouseUnableSpace = 150;
    public int count = 0;
    public Vector3 nowPlayerPosition;
    // Start is called before the first frame update
    public int playerHP;
    void Start()
    {
        playerHP = 100;
        nowPlayerPosition = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {   
        nowPlayerPosition = this.transform.position;
        if (Input.GetKey (KeyCode.A)) {
            this.transform.Translate (-0.1f,0.0f,0.0f);
        }
        if (Input.GetKey (KeyCode.D)) {
            this.transform.Translate (0.1f,0.0f,0.0f);
        }

        if (Input.GetKey (KeyCode.W)) {
            this.transform.Translate (0.0f,0.0f,0.05f);
        }
        if (Input.GetKey (KeyCode.S)) {
            this.transform.Translate (0.0f,0.0f,-0.05f);
        }

        Vector3 mousePosition = Input.mousePosition;
        if(mousePosition.x > 0 && mousePosition.x < Screen.width){
            if(mousePosition.x > Screen.width / 2 + mouseUnableSpace){
                if(mousePosition.x > Screen.width / 4 * 3){
                    this.transform.Rotate (0.0f,0.8f,0.0f);
                }
                else{
                    this.transform.Rotate (0.0f,0.6f,0.0f);
                }
            }
            else if(mousePosition.x < Screen.width / 2 - mouseUnableSpace){
                if(mousePosition.x < Screen.width / 4){
                    this.transform.Rotate (0.0f,-0.8f,0.0f);
                }
                else{
                    this.transform.Rotate (0.0f,-0.6f,0.0f);
                }
            }
        }
    }

    public void Damage(){
        playerHP -= 10;
        if(playerHP <= 0){
            float timer = 0.3f;
            //自分自身のゲームオブジェクト（Target）を0.3待ってから削除する
            Destroy (gameObject,timer);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        //Sphereが衝突したオブジェクトがPlaneだった場合
        if(collision.gameObject.name == "ForestField"){
            this.transform.position = nowPlayerPosition;
        }
    }
}
