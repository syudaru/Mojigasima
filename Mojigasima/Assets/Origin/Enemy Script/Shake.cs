using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shake : MonoBehaviour
{
    public float limitSec = 3;

    void Start()
    {
        Destroy(this.gameObject, limitSec);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
