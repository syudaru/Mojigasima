using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class en : MonoBehaviour
{
    public int speed;                //オブジェクトのスピード
    public int radius;               //円を描く半径
    private Vector3 defPosition;      //defPositionをVector3で定義する。
    float x;
    float y;

    // Use this for initialization
    void Start()
    {
       

        defPosition = transform.position;    //defPositionを自分のいる位置に設定する。
    }

    // Update is called once per frame
    void Update()
    {
        x = radius * Mathf.Sin(Time.time * speed);      //X軸の設定
        y = radius * Mathf.Cos(Time.time * speed);      //Y軸の設定

        transform.position = new Vector3(x + defPosition.x,y + defPosition.y, defPosition.z);  //自分のいる位置から座標を動かす。
    }
}