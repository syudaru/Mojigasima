using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossKu : MonoBehaviour
{
    public float speed = 10;
    public float angle = 90;

     void Update()
    {
        this.transform.Translate(speed / 50, 0, 0);
        this.transform.Rotate(0, 0, angle / 50);
    }
}
