using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundScript : MonoBehaviour
{

    private Rigidbody Shika;//バウンドさせたいオブジェクトを宣言

    //sphereに触れた時のメソッド
    private void OnCollisionEnter(Collision collision)
    {
        //Y軸方向に常に同じ力を与える
        Shika.AddForce(Vector3.up * 10f, ForceMode.Impulse);
    }
}
