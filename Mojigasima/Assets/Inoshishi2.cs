using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inoshishi2 : MonoBehaviour
{
    public float speed = 1;
    // Start is called before the first frame update
    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.Translate(speed / 100, 0, 0);
    }
}