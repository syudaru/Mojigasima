﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KENDAMAAttack : MonoBehaviour
{
    public GameObject KENDAMA = null;
    public Vector3 pos = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = KENDAMA.transform.position + pos;

    }
}
