using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public int speed = 10; //弾の速さ

    void Start()
    {
        //GetCompnent<Rigidbody2D>().velocity = transform.up.normalized * speed;
    }

}
